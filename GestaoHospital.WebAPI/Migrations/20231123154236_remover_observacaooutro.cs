using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoHospital.WebAPI.Migrations
{
    public partial class remover_observacaooutro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObservacaoOutro");

            migrationBuilder.AddColumn<string>(
                name: "Outros",
                table: "Observacao",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Outros",
                table: "Observacao");

            migrationBuilder.CreateTable(
                name: "ObservacaoOutro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ObservacaoId = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObservacaoOutro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObservacaoOutro_Observacao_ObservacaoId",
                        column: x => x.ObservacaoId,
                        principalTable: "Observacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObservacaoOutro_ObservacaoId",
                table: "ObservacaoOutro",
                column: "ObservacaoId");
        }
    }
}
