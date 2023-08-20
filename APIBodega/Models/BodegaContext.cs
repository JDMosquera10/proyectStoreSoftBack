
using Microsoft.EntityFrameworkCore;

namespace APIBodega.Models
{
    public class BodegaContext : DbContext
    {
            public BodegaContext(DbContextOptions<BodegaContext> options) : base(options)
            {
            }
            public DbSet<Bodega> bdga { get; set; }
            public DbSet<Permisos> usrio_prmso { get; set; }
    }
}
