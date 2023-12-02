using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Models.Usuario;
using GestaoHospital.WebAPI.Paginations;
using Microsoft.EntityFrameworkCore;

namespace GestaoHospital.WebAPI.Data.Repositories.Usuarios
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private readonly GHContext _context;

        public RepositoryUsuario(GHContext context)
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

        public async Task<(List<EntityUsuario>, int)> GetAllUsusariosAsync(
            RequestData<GetUsuariosFilterDto> request
        )
        {
            IQueryable<EntityUsuario> query = _context.Usuarios;

            if (request.Filter.Id.HasValue)
            {
                query = query.Where(x => x.Id == request.Filter.Id.Value);
            }

            int count = query.Count();
            query = query
                .Include(o => o.Perfil)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize);
            query = query.AsNoTracking().OrderBy(m => m.Id);
            return (await query.ToListAsync(), count);
        }
    }
}
