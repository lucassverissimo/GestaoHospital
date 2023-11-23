using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class MapaDto
    {
        public int Id { get; set; }
        public PacienteDto Paciente { get; set; }
        public int Leito { get; set; }
        public string Diagnostico { get; set; }
        public ObservacaoDto Observacao { get; set; }
        public CaracteristicaDietaDto CaracteristicaDieta { get; set; }
        public AnotacaoDto Anotacao { get; set; }
        public string ObservacaoDieta { get; set; }
        public string Dieta { get; set; }
        public DateTime DataPrescricao { get; set; }
    }

    

    

    
}