using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektSklepp.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produkt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produkt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ilosc = table.Column<int>(type: "int", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cena_produktu = table.Column<int>(type: "int", nullable: false),
                    firma_produktu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwa_produktu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sklepID = table.Column<int>(type: "int", nullable: false)
                });
               
        }
    }
}
