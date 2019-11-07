using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestionServer.Migrations
{
    public partial class questionserverupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DownvoteCount",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpvoteCount",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DownvoteCount",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UpvoteCount",
                table: "Questions");
        }
    }
}
