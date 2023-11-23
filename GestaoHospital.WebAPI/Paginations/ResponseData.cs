using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace GestaoHospital.WebAPI.Paginations
{
    public class ResponseData<T>
    {
        public T Data { get; set; }
        public ResponseMetaData MetaData { get; set; }
        
    }
}