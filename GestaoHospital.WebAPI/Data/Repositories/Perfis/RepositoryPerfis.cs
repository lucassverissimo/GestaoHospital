using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Models.Usuario;
using GestaoHospital.WebAPI.Paginations;
using Microsoft.EntityFrameworkCore;

namespace GestaoHospital.WebAPI.Data.Repositories.Mapas
{
    public class RepositoryPerfil : IRepositoryPerfil
    {
        private readonly GHContext _context;

        public RepositoryPerfil(GHContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity)
            where T : class
        {
            _context.Add(entity);
        }

        public async Task AddAsync<T>(T entity)
            where T : class
        {
            await _context.AddAsync(entity);
        }

        public void Delete<T>(T entity)
            where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity)
            where T : class
        {
            _context.Update(entity);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public async Task<(List<EntityMapa>, int)> GetAllMapasAsync(
            RequestData<GetMapasFilterDto> request
        )
        {
            IQueryable<EntityMapa> query = _context.Mapas;

            if (request.Filter.Leito.HasValue)
            {
                query = query.Where(x => x.Leito == request.Filter.Leito.Value);
            }

            if (request.Filter.Id.HasValue)
            {
                query = query.Where(x => x.Id == request.Filter.Id.Value);
            }

            if (request.Filter.PacienteId.HasValue)
            {
                query = query.Where(x => x.PacienteId == request.Filter.PacienteId.Value);
            }
            int count = query.Count();
            query = query
                .Include(o => o.Paciente)
                .Include(o => o.Observacao)
                .Include(o => o.CaracteristicaDieta)
                .Include(o => o.Anotacao)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize);
            query = query.AsNoTracking().OrderBy(m => m.Id);
            return (await query.ToListAsync(), count);
        }

        public EntityPerfil GetById(int id)
        {
            return _context.Perfis.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
