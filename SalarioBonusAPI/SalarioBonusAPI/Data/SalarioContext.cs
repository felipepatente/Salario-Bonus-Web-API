using Microsoft.EntityFrameworkCore;
using SalarioBonusAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalarioBonusAPI.Data
{
    public class SalarioContext: DbContext
    {
        public readonly DbSet<SalarioBonusVendedor> SalarioBonusVendedor;

        public SalarioContext(DbContextOptions<SalarioContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalarioBonusVendedor>()
                .Property(s => s.SalarioFixo)
                .HasColumnType("Decimal(10,5)");

            modelBuilder.Entity<SalarioBonusVendedor>()
               .Property(s => s.TotalVendas)
               .HasColumnType("Decimal(10,5)");

            modelBuilder.Entity<SalarioBonusVendedor>()
                .Property(s => s.SalarioReceber)
                .HasColumnType("Decimal(10,5)");
        }
    }
}
