using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "CustomerAccountTransictionses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "CustomerAccountTransictionses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountTransictionses_ReceiverId",
                table: "CustomerAccountTransictionses",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountTransictionses_SenderId",
                table: "CustomerAccountTransictionses",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountTransictionses_CustomerAccounts_ReceiverId",
                table: "CustomerAccountTransictionses",
                column: "ReceiverId",
                principalTable: "CustomerAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountTransictionses_CustomerAccounts_SenderId",
                table: "CustomerAccountTransictionses",
                column: "SenderId",
                principalTable: "CustomerAccounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountTransictionses_CustomerAccounts_ReceiverId",
                table: "CustomerAccountTransictionses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountTransictionses_CustomerAccounts_SenderId",
                table: "CustomerAccountTransictionses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountTransictionses_ReceiverId",
                table: "CustomerAccountTransictionses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountTransictionses_SenderId",
                table: "CustomerAccountTransictionses");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "CustomerAccountTransictionses");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "CustomerAccountTransictionses");
        }
    }
}
