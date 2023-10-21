using Microsoft.EntityFrameworkCore;

namespace Prospecta.Models
{
    public class ProspectaDbContext : DbContext
    {
        public ProspectaDbContext(DbContextOptions<ProspectaDbContext> options) : base(options) { }

        public DbSet<Lead> Leads { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<UsuarioEmpresa> Usuarios { get; set; }

    }
}
