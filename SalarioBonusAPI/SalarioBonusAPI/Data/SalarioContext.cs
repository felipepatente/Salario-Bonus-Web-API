using Microsoft.EntityFrameworkCore;
using SalarioBonusAPI.Models;

namespace SalarioBonusAPI.Data
{
    public class SalarioContext: DbContext
    {
        public DbSet<SalarioVendedor> SalarioVendedor { get; set; }

        public SalarioContext(DbContextOptions<SalarioContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalarioVendedor>()
                .Property(s => s.SalarioFixo)
                .HasColumnType("Decimal(10,5)");

            modelBuilder.Entity<SalarioVendedor>()
               .Property(s => s.ValorTotalVendas)
               .HasColumnType("Decimal(10,5)");

            modelBuilder.Entity<SalarioVendedor>()
                .Property(s => s.SalarioReceber)
                .HasColumnType("Decimal(10,5)");
        }
    }
}
