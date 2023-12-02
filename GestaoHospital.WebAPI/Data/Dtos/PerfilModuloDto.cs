namespace GestaoHospital.WebAPI.Data.Dtos
{
    public class PerfilModuloDto
    {
        public int Id { get; set; }
        public int IdModulo { get; set; }
        public ModuloDto Modulo { get; set; }
        public int IdPerfil { get; set; }
        public PerfilDto Perfil { get; set; }
    }
}
