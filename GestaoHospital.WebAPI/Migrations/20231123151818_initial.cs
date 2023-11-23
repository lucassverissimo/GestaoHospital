using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoHospital.WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anotacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    Prescricao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anotacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicaDieta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dieta = table.Column<string>(nullable: false),
                    Sistema = table.Column<string>(nullable: false),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Evoluido = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicaDieta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Observacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dialise = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObservacaoOutro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(nullable: false),
                    ObservacaoId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Mapas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Leito = table.Column<int>(nullable: false),
                    Diagnostico = table.Column<string>(nullable: false),
                    ObservacaoDieta = table.Column<string>(nullable: false),
                    Dieta = table.Column<string>(nullable: false),
                    DataPrescricao = table.Column<DateTime>(nullable: false),
                    PacienteId = table.Column<int>(nullable: false),
                    ObservacaoId = table.Column<int>(nullable: false),
                    CaracteristicaDietaId = table.Column<int>(nullable: false),
                    AnotacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mapas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mapas_Anotacao_AnotacaoId",
                        column: x => x.AnotacaoId,
                        principalTable: "Anotacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mapas_CaracteristicaDieta_CaracteristicaDietaId",
                        column: x => x.CaracteristicaDietaId,
                        principalTable: "CaracteristicaDieta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mapas_Observacao_ObservacaoId",
                        column: x => x.ObservacaoId,
                        principalTable: "Observacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mapas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mapas_AnotacaoId",
                table: "Mapas",
                column: "AnotacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mapas_CaracteristicaDietaId",
                table: "Mapas",
                column: "CaracteristicaDietaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mapas_ObservacaoId",
                table: "Mapas",
                column: "ObservacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mapas_PacienteId",
                table: "Mapas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ObservacaoOutro_ObservacaoId",
                table: "ObservacaoOutro",
                column: "ObservacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mapas");

            migrationBuilder.DropTable(
                name: "ObservacaoOutro");

            migrationBuilder.DropTable(
                name: "Anotacao");

            migrationBuilder.DropTable(
                name: "CaracteristicaDieta");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Observacao");
        }
    }
}
