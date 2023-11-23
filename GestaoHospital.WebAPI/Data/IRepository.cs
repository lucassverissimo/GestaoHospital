using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoHospital.WebAPI.Data.Dtos;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Paginations;

namespace GestaoHospital.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        Task AddAsync<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Task<(List<Mapa>,int)> GetAllMapasAsync(RequestData<GetMapasFilterDto> request);
    }
}