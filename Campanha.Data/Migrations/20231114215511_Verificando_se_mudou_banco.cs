using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Campanha.Data.Migrations
{
    /// <inheritdoc />
    public partial class Verificando_se_mudou_banco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_equipe_equipe_id",
                schema: "public",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_voluntario_equipe_equipe_interesse",
                schema: "public",
                table: "voluntario");

            migrationBuilder.RenameColumn(
                name: "equipe_interesse",
                schema: "public",
                table: "voluntario",
                newName: "equipe_interesse_id");

            migrationBuilder.RenameIndex(
                name: "IX_voluntario_equipe_interesse",
                schema: "public",
                table: "voluntario",
                newName: "IX_voluntario_equipe_interesse_id");

            migrationBuilder.AlterColumn<int>(
                name: "equipe_interesse_id",
                schema: "public",
                table: "voluntario",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "equipe_id",
                schema: "public",
                table: "usuario",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_equipe_equipe_id",
                schema: "public",
                table: "usuario",
                column: "equipe_id",
                principalTable: "equipe",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_voluntario_equipe_equipe_interesse_id",
                schema: "public",
                table: "voluntario",
                column: "equipe_interesse_id",
                principalTable: "equipe",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_equipe_equipe_id",
                schema: "public",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_voluntario_equipe_equipe_interesse_id",
                schema: "public",
                table: "voluntario");

            migrationBuilder.RenameColumn(
                name: "equipe_interesse_id",
                schema: "public",
                table: "voluntario",
                newName: "equipe_interesse");

            migrationBuilder.RenameIndex(
                name: "IX_voluntario_equipe_interesse_id",
                schema: "public",
                table: "voluntario",
                newName: "IX_voluntario_equipe_interesse");

            migrationBuilder.AlterColumn<int>(
                name: "equipe_interesse",
                schema: "public",
                table: "voluntario",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "equipe_id",
                schema: "public",
                table: "usuario",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_equipe_equipe_id",
                schema: "public",
                table: "usuario",
                column: "equipe_id",
                principalTable: "equipe",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_voluntario_equipe_equipe_interesse",
                schema: "public",
                table: "voluntario",
                column: "equipe_interesse",
                principalTable: "equipe",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
