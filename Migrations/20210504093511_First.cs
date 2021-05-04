using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ValueTypeExample.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PnrNo = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    PnrDetail_DepartureCode = table.Column<string>(type: "text", nullable: true),
                    PnrDetail_ArrivalCode = table.Column<string>(type: "text", nullable: true),
                    PnrDetail_DepartureName = table.Column<string>(type: "text", nullable: true),
                    PnrDetail_ArrivalName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
