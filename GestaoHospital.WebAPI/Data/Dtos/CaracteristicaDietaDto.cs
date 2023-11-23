using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class CaracteristicaDietaDto
    {
        public int Id { get; set; }
        public string Dieta { get; set; }
        public string Sistema { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Evoluido { get; set; }
    }
}