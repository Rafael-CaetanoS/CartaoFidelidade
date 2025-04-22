using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CartaoFidelidade.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class createCupom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    dataCriacao = table.Column<DateTime>(type: "timestamp with time zone", maxLength: 100, nullable: false),
                    lojaId = table.Column<Guid>(type: "uuid", maxLength: 15, nullable: false),
                    clienteId = table.Column<Guid>(type: "uuid", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cupons_Clientes_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cupons_Lojas_lojaId",
                        column: x => x.lojaId,
                        principalTable: "Lojas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cupons_clienteId",
                table: "Cupons",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cupons_lojaId",
                table: "Cupons",
                column: "lojaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cupons");
        }
    }
}
