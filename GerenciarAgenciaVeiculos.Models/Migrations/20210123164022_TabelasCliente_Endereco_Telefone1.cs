using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciarAgenciaVeiculos.Models.Migrations
{
    public partial class TabelasCliente_Endereco_Telefone1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Clientes_ClienteId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Telefones_ClienteId",
                table: "Telefones");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Telefones");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Enderecos");

            migrationBuilder.AddColumn<int>(
                name: "EnderecosId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TelefonesId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EnderecosId",
                table: "Clientes",
                column: "EnderecosId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TelefonesId",
                table: "Clientes",
                column: "TelefonesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Enderecos_EnderecosId",
                table: "Clientes",
                column: "EnderecosId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Telefones_TelefonesId",
                table: "Clientes",
                column: "TelefonesId",
                principalTable: "Telefones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Enderecos_EnderecosId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Telefones_TelefonesId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_EnderecosId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_TelefonesId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EnderecosId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TelefonesId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Telefones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Enderecos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ClienteId",
                table: "Telefones",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Clientes_ClienteId",
                table: "Telefones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
