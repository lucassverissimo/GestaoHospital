using System.Collections.Generic;
using GestaoHospital.WebAPI.Models.Usuario;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class GetUsuarioDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public PerfilDto Perfil { get; set; }
    }
}
