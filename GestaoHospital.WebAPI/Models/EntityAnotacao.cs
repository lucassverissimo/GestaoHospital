using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    [Table("Anotacao")]
    public class EntityAnotacao
    {
        public EntityAnotacao() { }

        public EntityAnotacao(int id, string descricao, DateTime prescricao)
        {
            Id = id;
            Descricao = descricao;
            Prescricao = prescricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Prescricao { get; set; }
    }
}
