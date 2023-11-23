using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class AnotacaoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Prescricao { get; set; }
    }
}