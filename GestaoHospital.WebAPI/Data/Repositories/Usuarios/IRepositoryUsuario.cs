using System.Collections.Generic;
using System.Threading.Tasks;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Models.Usuario;
using GestaoHospital.WebAPI.Paginations;

namespace GestaoHospital.WebAPI.Data.Repositories.Usuarios
{
    public interface IRepositoryUsuario
    {
        void Add<T>(T entity)
            where T : class;
        Task AddAsync<T>(T entity)
            where T : class;
        void Update<T>(T entity)
            where T : class;
        void Delete<T>(T entity)
            where T : class;
        bool SaveChanges();

        Task<(List<EntityUsuario>, int)> GetAllUsusariosAsync(
            RequestData<GetUsuariosFilterDto> request
        );
    }
}
