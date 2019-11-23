﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalarioBonusAPI.Data;

namespace SalarioBonusAPI.Migrations
{
    [DbContext(typeof(SalarioContext))]
    [Migration("20191123145935_MudandoNomeTabela")]
    partial class MudandoNomeTabela
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalarioBonusAPI.Models.SalarioVendedor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("SalarioFixo")
                        .HasColumnType("Decimal(10,5)");

                    b.Property<decimal>("SalarioReceber")
                        .HasColumnType("Decimal(10,5)");

                    b.Property<decimal>("TotalVendas")
                        .HasColumnType("Decimal(10,5)");

                    b.Property<string>("Vendedor");

                    b.HasKey("ID");

                    b.ToTable("SalarioVendedor");
                });
#pragma warning restore 612, 618
        }
    }
}
