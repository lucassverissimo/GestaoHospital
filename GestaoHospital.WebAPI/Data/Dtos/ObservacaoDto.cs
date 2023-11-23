using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class ObservacaoDto
    {
        public int Id { get; set; }
        public string Dialise { get; set; }
        public string Outros { get; set; }
    }    
}