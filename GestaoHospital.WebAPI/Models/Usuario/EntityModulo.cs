using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoHospital.WebAPI.Models.Usuario
{
    [Table("Modulos")]
    public class EntityModulo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<EntityPerfilModulo> Perfis { get; set; }
    }
}
