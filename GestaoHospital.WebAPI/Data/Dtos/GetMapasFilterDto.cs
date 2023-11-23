using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class GetMapasFilterDto
    {
        public int? Id { get; set; }
        public int? Leito { get; set; }
        public int? PacienteId { get; set; }        
    }
}