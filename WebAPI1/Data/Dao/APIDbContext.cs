using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>().OwnsOne(c => c.endereco);

        modelBuilder.Entity<Cliente>().HasKey(c => c.Id);

    }
}
