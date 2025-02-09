using APIs_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace APIs_crud.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
