using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalarioBonusAPI.Migrations
{
    public partial class MudandoNomeTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalarioBonusVendedor");

            migrationBuilder.CreateTable(
                name: "SalarioVendedor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vendedor = table.Column<string>(nullable: true),
                    SalarioFixo = table.Column<decimal>(type: "Decimal(10,5)", nullable: false),
                    TotalVendas = table.Column<decimal>(type: "Decimal(10,5)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "SalarioBonusVendedor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalarioFixo = table.Column<decimal>(type: "Decimal(10,5)", nullable: false),
                    SalarioReceber = table.Column<decimal>(type: "Decimal(10,5)", nullable: false),
                    TotalVendas = table.Column<decimal>(type: "Decimal(10,5)", nullable: false),
                    Vendedor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalarioBonusVendedor", x => x.ID);
                });
        }
    }
}
