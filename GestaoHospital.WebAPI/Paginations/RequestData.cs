using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Paginations
{
    public class RequestData<T> : PaginationParams where T : class
    {
        public T Filter { get; set; }
        
    }
}