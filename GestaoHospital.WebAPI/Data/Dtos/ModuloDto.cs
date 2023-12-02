using System.Collections.Generic;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class ModuloDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<PerfilModuloDto> Perfis { get; set; }
    }
}
