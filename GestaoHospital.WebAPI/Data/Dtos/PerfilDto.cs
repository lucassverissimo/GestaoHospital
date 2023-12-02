using System.Collections.Generic;

namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class PerfilDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<PerfilModuloDto> Modulos { get; set; }
    }
}
