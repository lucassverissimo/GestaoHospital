using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    public class Observacao
    {
        public Observacao() { }
        public Observacao(int id, string dialise, string outros)
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