using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        public DbSet<Models.Categoria>? Categorias { get; set; }
        public DbSet<Models.Produto>? Produtos { get; set; }

    }
}
