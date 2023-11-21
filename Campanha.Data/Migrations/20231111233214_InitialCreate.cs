using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Campanha.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "beneficios",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beneficios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "campanha",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    data_inicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    data_finalizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_campanha", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "equipe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipe", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "familia",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    nit = table.Column<string>(type: "text", nullable: true),
                    genero = table.Column<int>(type: "integer", nullable: false),
                    cpf = table.Column<string>(type: "text", nullable: true),
                    logradouro = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    cep = table.Column<string>(type: "text", nullable: true),
                    celular = table.Column<string>(type: "text", nullable: true),
                    tel_fixo = table.Column<string>(type: "text", nullable: true),
                    qtde_pessoas = table.Column<int>(type: "integer", nullable: false),
                    renda_familiar_estimada = table.Column<double>(type: "double precision", nullable: false),
                    possui_filhos = table.Column<bool>(type: "boolean", nullable: false),
                    frequenta_igreja = table.Column<bool>(type: "boolean", nullable: false),
                    pertence_grupo_oracao = table.Column<bool>(type: "boolean", nullable: false),
                    igreja_frequentada = table.Column<string>(type: "text", nullable: true),
                    grupo_oracao = table.Column<string>(type: "text", nullable: true),
                    recebe_pessoas = table.Column<bool>(type: "boolean", nullable: false),
                    dias_receber_pessoas = table.Column<string>(type: "text", nullable: true),
                    codigo_campanha = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_familia", x => x.id);
                    table.ForeignKey(
                        name: "FK_familia_campanha_codigo_campanha",
                        column: x => x.codigo_campanha,
                        principalTable: "campanha",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    cargo = table.Column<string>(type: "text", nullable: true),
                    login = table.Column<string>(type: "text", nullable: true),
                    senha = table.Column<string>(type: "text", nullable: true),
                    equipe_id = table.Column<int>(type: "integer", nullable: false),
                    ativo = table.Column<bool>(type: "boolean", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    cpf = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    contato = table.Column<string>(type: "text", nullable: true),
                    contato_secundario = table.Column<string>(type: "text", nullable: true),
                    genero = table.Column<int>(type: "integer", nullable: false),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    logradouro = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    cep = table.Column<string>(type: "text", nullable: true),
                    grupo_pastoral = table.Column<string>(type: "text", nullable: true),
                    horario_disponivel = table.Column<string>(type: "text", nullable: true),
                    atividade_projeto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuario_equipe_equipe_id",
                        column: x => x.equipe_id,
                        principalTable: "equipe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "voluntario",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    equipe_interesse = table.Column<int>(type: "integer", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    cpf = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    contato = table.Column<string>(type: "text", nullable: true),
                    contato_secundario = table.Column<string>(type: "text", nullable: true),
                    genero = table.Column<int>(type: "integer", nullable: false),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    logradouro = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    cep = table.Column<string>(type: "text", nullable: true),
                    grupo_pastoral = table.Column<string>(type: "text", nullable: true),
                    horario_disponivel = table.Column<string>(type: "text", nullable: true),
                    atividade_projeto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voluntario", x => x.id);
                    table.ForeignKey(
                        name: "FK_voluntario_equipe_equipe_interesse",
                        column: x => x.equipe_interesse,
                        principalTable: "equipe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "beneficios_familia",
                columns: table => new
                {
                    familia_id = table.Column<int>(type: "integer", nullable: false),
                    beneficio_id = table.Column<int>(type: "integer", nullable: false),
                    opcao_beneficio = table.Column<int>(type: "integer", nullable: false),
                    data_inicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    data_finalizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beneficios_familia", x => new { x.familia_id, x.beneficio_id, x.opcao_beneficio });
                    table.ForeignKey(
                        name: "FK_beneficios_familia_beneficios_beneficio_id",
                        column: x => x.beneficio_id,
                        principalTable: "beneficios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_beneficios_familia_familia_familia_id",
                        column: x => x.familia_id,
                        principalTable: "familia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_beneficios_familia_beneficio_id",
                table: "beneficios_familia",
                column: "beneficio_id");

            migrationBuilder.CreateIndex(
                name: "IX_familia_codigo_campanha",
                table: "familia",
                column: "codigo_campanha");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_equipe_id",
                schema: "public",
                table: "usuario",
                column: "equipe_id");

            migrationBuilder.CreateIndex(
                name: "IX_voluntario_equipe_interesse",
                schema: "public",
                table: "voluntario",
                column: "equipe_interesse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "beneficios_familia");

            migrationBuilder.DropTable(
                name: "usuario",
                schema: "public");

            migrationBuilder.DropTable(
                name: "voluntario",
                schema: "public");

            migrationBuilder.DropTable(
                name: "beneficios");

            migrationBuilder.DropTable(
                name: "familia");

            migrationBuilder.DropTable(
                name: "equipe");

            migrationBuilder.DropTable(
                name: "campanha");
        }
    }
}
