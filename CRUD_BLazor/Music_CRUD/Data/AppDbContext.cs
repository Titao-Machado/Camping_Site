using Microsoft.EntityFrameworkCore;
using Music_CRUD.Modelos;

namespace Music_CRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }


        public DbSet<Categorias> Categorias { get; set; } = null!;

    }
}
