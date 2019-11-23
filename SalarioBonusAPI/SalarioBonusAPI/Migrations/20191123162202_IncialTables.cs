using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalarioBonusAPI.Migrations
{
    public partial class IncialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalarioVendedor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vendedor = table.Column<string>(nullable: true),
                    SalarioFixo = table.Column<decimal>(type: "Decimal(10,5)", nullable: false),
                    ValorTotalVendas = table.Column<decimal>(type: "Decimal(10,5)", nullable: false),
                    SalarioReceber = table.Column<decimal>(type: "Decimal(10,5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalarioVendedor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalarioVendedor");
        }
    }
}
