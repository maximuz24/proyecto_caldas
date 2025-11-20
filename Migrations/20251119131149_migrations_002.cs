using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rincon.Migrations
{
    /// <inheritdoc />
    public partial class migrations_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "usuario_nombre",
                table: "Usuarios",
                newName: "Usuario_nombre");

            migrationBuilder.RenameColumn(
                name: "usario_correo",
                table: "Usuarios",
                newName: "Usuario_correo");

            migrationBuilder.RenameColumn(
                name: "usario_constrasena",
                table: "Usuarios",
                newName: "Usuario_contraseña");

            migrationBuilder.RenameColumn(
                name: "usario_apellido",
                table: "Usuarios",
                newName: "Usuario_apellido");

            migrationBuilder.AddColumn<string>(
                name: "Usuario_Salt",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario_Salt",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Usuario_nombre",
                table: "Usuarios",
                newName: "usuario_nombre");

            migrationBuilder.RenameColumn(
                name: "Usuario_correo",
                table: "Usuarios",
                newName: "usario_correo");

            migrationBuilder.RenameColumn(
                name: "Usuario_contraseña",
                table: "Usuarios",
                newName: "usario_constrasena");

            migrationBuilder.RenameColumn(
                name: "Usuario_apellido",
                table: "Usuarios",
                newName: "usario_apellido");
        }
    }
}
