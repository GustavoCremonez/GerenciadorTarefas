using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorTarefas.Migrations
{
    public partial class UpdateTaskModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_UserModel_userId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Tasks",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_userId",
                table: "Tasks",
                newName: "IX_Tasks_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_UserModel_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_UserModel_UserId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tasks",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                newName: "IX_Tasks_userId");

            migrationBuilder.AddColumn<long>(
                name: "IdUser",
                table: "Tasks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_UserModel_userId",
                table: "Tasks",
                column: "userId",
                principalTable: "UserModel",
                principalColumn: "Id");
        }
    }
}
