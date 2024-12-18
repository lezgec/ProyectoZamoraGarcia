using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProyectoZamoraGarcia.Entidades
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ProyectoZamoraGarcia;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
