using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoHospital.WebAPI.Models.Usuario
{
    [Table("Usuarios")]
    public class EntityUsuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public EntityPerfil Perfil { get; set; }
    }
}
