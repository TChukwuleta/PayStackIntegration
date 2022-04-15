using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaystactIntegrationWithDotNet.Migrations
{
    public partial class updateTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Transactions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Transactions");
        }
    }
}
