using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    public class CaracteristicaDieta
    {
        public CaracteristicaDieta() { }
        public CaracteristicaDieta(int id, string dieta, string sistema, DateTime inicio, DateTime evoluido)
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