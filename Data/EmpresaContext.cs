using Microsoft.EntityFrameworkCore;
using pc2.Models;

namespace pc2.Data
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Usuario> Datos { get; set; }

        public EmpresaContext(DbContextOptions dco) : base(dco) {

        }
    }
}