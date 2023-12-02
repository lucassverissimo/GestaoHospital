using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    [Table("CaracteristicaDieta")]
    public class EntityCaracteristicaDieta
    {
        public EntityCaracteristicaDieta() { }

        public EntityCaracteristicaDieta(
            int id,
            string dieta,
            string sistema,
            DateTime inicio,
            DateTime evoluido
        )
        {
            Id = id;
            Dieta = dieta;
            Sistema = sistema;
            Inicio = inicio;
            Evoluido = evoluido;
        }

        public int Id { get; set; }
        public string Dieta { get; set; }
        public string Sistema { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Evoluido { get; set; }
    }
}
