using Microsoft.EntityFrameworkCore.Migrations;

namespace SCG.Infrastructure.Migrations
{
    public partial class AtualizaEntidadeCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Cliente",
                newName: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Cliente",
                newName: "ClienteID");
        }
    }
}
