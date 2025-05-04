using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CartaoFidelidade.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class createSolicitacaoCupom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitacaoCupom",
                columns: table => new
                {
                    CupomId = table.Column<int>(type: "integer", nullable: false),
                    SolicitacaoId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacaoCupom", x => new { x.CupomId, x.SolicitacaoId });
                    table.ForeignKey(
                        name: "FK_SolicitacaoCupom_Cupons_CupomId",
                        column: x => x.CupomId,
                        principalTable: "Cupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitacaoCupom_Solicitacoes_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "Solicitacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacaoCupom_SolicitacaoId",
                table: "SolicitacaoCupom",
                column: "SolicitacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitacaoCupom");
        }
    }
}
