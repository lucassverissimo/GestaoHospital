using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoHospital.WebAPI.Models;
using GestaoHospital.WebAPI.Models.Usuario;
using Microsoft.EntityFrameworkCore;

namespace GestaoHospital.WebAPI.Data
{
    public class GHContext : DbContext
    {
        public GHContext(DbContextOptions<GHContext> options)
            : base(options) { }

        public DbSet<EntityPaciente> Pacientes { get; set; }
        public DbSet<EntityMapa> Mapas { get; set; }
        public DbSet<EntityUsuario> Usuarios { get; set; }
        public DbSet<EntityModulo> Modulos { get; set; }
        public DbSet<EntityPerfil> Perfis { get; set; }
    }
}
