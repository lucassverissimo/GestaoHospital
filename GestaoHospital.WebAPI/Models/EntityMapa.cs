using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    [Table("Mapas")]
    public class EntityMapa
    {
        public EntityMapa() { }

        public EntityMapa(
            int id,
            int leito,
            string diagnostico,
            string observacaoDieta,
            string dieta,
            DateTime dataPrescricao,
            int pacienteId,
            int observacaoId,
            int caracteristicaDietaId,
            int anotacaoId
        )
        {
            Id = id;
            Leito = leito;
            Diagnostico = diagnostico;
            ObservacaoDieta = observacaoDieta;
            Dieta = dieta;
            DataPrescricao = dataPrescricao;
            PacienteId = pacienteId;
            ObservacaoId = observacaoId;
            CaracteristicaDietaId = caracteristicaDietaId;
            AnotacaoId = anotacaoId;
        }

        public int Id { get; set; }
        public int Leito { get; set; }
        public string Diagnostico { get; set; }
        public string ObservacaoDieta { get; set; }
        public string Dieta { get; set; }
        public DateTime DataPrescricao { get; set; }
        public EntityPaciente Paciente { get; set; }
        public int PacienteId { get; set; }
        public EntityObservacao Observacao { get; set; }
        public int ObservacaoId { get; set; }
        public EntityCaracteristicaDieta CaracteristicaDieta { get; set; }
        public int CaracteristicaDietaId { get; set; }
        public EntityAnotacao Anotacao { get; set; }
        public int AnotacaoId { get; set; }
    }
}
