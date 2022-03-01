using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektSklepp.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.RenameTable(
                name: "Produkty",
                newName: "produkt");

            migrationBuilder.RenameColumn(
                name: "ilosc",
                table: "produkt",
                newName: "Ilosc");

            migrationBuilder.RenameColumn(
                name: "SklepID",
                table: "produkt",
                newName: "sklepID");

            migrationBuilder.RenameColumn(
                name: "Nazwa",
                table: "produkt",
                newName: "nazwa_produktu");

            migrationBuilder.RenameColumn(
                name: "Cena",
                table: "produkt",
                newName: "cena_produktu");

            migrationBuilder.AddColumn<string>(
                name: "Miasto",
                table: "produkt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firma_produktu",
                table: "produkt",
                type: "nvarchar(max)",
                nullable: true);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_produkt",
                table: "produkt");

            migrationBuilder.DropColumn(
                name: "Miasto",
                table: "produkt");

            migrationBuilder.DropColumn(
                name: "firma_produktu",
                table: "produkt");

            migrationBuilder.RenameTable(
                name: "produkt",
                newName: "Produkty");

            migrationBuilder.RenameColumn(
                name: "sklepID",
                table: "Produkty",
                newName: "SklepID");

            migrationBuilder.RenameColumn(
                name: "Ilosc",
                table: "Produkty",
                newName: "ilosc");

            migrationBuilder.RenameColumn(
                name: "nazwa_produktu",
                table: "Produkty",
                newName: "Nazwa");

            migrationBuilder.RenameColumn(
                name: "cena_produktu",
                table: "Produkty",
                newName: "Cena");

     
        }
    }
}
