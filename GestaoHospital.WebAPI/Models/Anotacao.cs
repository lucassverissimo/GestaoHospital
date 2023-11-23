using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    public class Anotacao
    {
        public Anotacao() { }
        public Anotacao(int id, string descricao, DateTime prescricao)
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