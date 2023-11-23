using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoHospital.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoHospital.WebAPI.Data
{
    public class GHContext : DbContext
    {
        public GHContext(DbContextOptions<GHContext> options) : base(options) { }
        
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Mapa> Mapas { get; set; }
        
    }
}