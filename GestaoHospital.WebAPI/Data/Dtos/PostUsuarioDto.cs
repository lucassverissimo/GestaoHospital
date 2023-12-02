using GestaoHospital.WebAPI.Models.Usuario;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class PostUsuarioDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int? IdPerfil { get; set; }
    }
}
