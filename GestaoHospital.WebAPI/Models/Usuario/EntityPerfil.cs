using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoHospital.WebAPI.Models.Usuario
{
    [Table("Perfis")]
    public class EntityPerfil
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<EntityPerfilModulo> Modulos { get; set; }
    }
}
