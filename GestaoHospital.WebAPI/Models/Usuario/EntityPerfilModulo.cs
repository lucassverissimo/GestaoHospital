using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoHospital.WebAPI.Models.Usuario
{
    [Table("PerfilModulo")]
    public class EntityPerfilModulo
    {
        public int Id { get; set; }
        public int IdModulo { get; set; }
        public EntityModulo Modulo { get; set; }
        public int IdPerfil { get; set; }
        public EntityPerfil Perfil { get; set; }
    }
}
