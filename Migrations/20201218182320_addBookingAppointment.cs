using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sunrisehospital.Migrations
{
    public partial class AddBookingAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "BookAppointments",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "BookAppointments",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
