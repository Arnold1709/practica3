using Microsoft.EntityFrameworkCore;

namespace practica3.Models
{
    public class BuscarContext : DbContext
    {
        public DbSet <Producto> Productos {get;set; }
        public DbSet <Categoria> Categorias {get;set; }

        public BuscarContext(DbContextOptions dco) : base(dco) {}
    }
}