using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHospital.WebAPI.Models
{
    public class Paciente
    {
        public Paciente() { }
        public Paciente(int id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;            
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        
    }
}