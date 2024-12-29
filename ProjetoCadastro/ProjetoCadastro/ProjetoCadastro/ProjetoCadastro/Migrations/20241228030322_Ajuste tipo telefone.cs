using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoCadastro.Migrations
{
    public partial class Ajustetipotelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Telefones");

            migrationBuilder.AddColumn<int>(
                name: "TipoTelefone",
                table: "Telefones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoTelefone",
                table: "Telefones");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Telefones",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
