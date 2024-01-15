using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Music_Shop.Migrations
{
    public partial class Producer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Producer",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "ProducerID",
                table: "Song",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Song_ProducerID",
                table: "Song",
                column: "ProducerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Producer_ProducerID",
                table: "Song",
                column: "ProducerID",
                principalTable: "Producer",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Producer_ProducerID",
                table: "Song");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropIndex(
                name: "IX_Song_ProducerID",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "ProducerID",
                table: "Song");

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "Song",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
