using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLeaveModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemainingDays",
                table: "LeaveBalances");

            migrationBuilder.AddColumn<string>(
                name: "DecisionComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DecisionDate",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDays",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DecisionComment",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "DecisionDate",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<int>(
                name: "RemainingDays",
                table: "LeaveBalances",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
