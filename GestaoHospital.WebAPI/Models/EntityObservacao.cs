using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    [Table("Observacao")]
    public class EntityObservacao
    {
        public EntityObservacao() { }

        public EntityObservacao(int id, string dialise, string outros)
        {
            Id = id;
            Dialise = dialise;
            Outros = outros;
        }

        public int Id { get; set; }
        public string Dialise { get; set; }
        public string Outros { get; set; }
    }
}
