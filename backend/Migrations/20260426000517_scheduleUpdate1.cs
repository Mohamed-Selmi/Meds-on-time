using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class scheduleUpdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicationSchedules_Medications_medicationId",
                table: "MedicationSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationSchedules_Users_userId",
                table: "MedicationSchedules");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "MedicationSchedules",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "numberOfPills",
                table: "MedicationSchedules",
                newName: "NumberOfPills");

            migrationBuilder.RenameColumn(
                name: "medicationId",
                table: "MedicationSchedules",
                newName: "MedicationId");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "MedicationSchedules",
                newName: "Duration");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationSchedules_userId",
                table: "MedicationSchedules",
                newName: "IX_MedicationSchedules_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationSchedules_medicationId",
                table: "MedicationSchedules",
                newName: "IX_MedicationSchedules_MedicationId");

            migrationBuilder.AddColumn<string>(
                name: "dayOfWeek",
                table: "ReminderPlannings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "EndDate",
                table: "MedicationSchedules",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "StartDate",
                table: "MedicationSchedules",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationSchedules_Medications_MedicationId",
                table: "MedicationSchedules",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationSchedules_Users_UserId",
                table: "MedicationSchedules",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicationSchedules_Medications_MedicationId",
                table: "MedicationSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationSchedules_Users_UserId",
                table: "MedicationSchedules");

            migrationBuilder.DropColumn(
                name: "dayOfWeek",
                table: "ReminderPlannings");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "MedicationSchedules");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "MedicationSchedules");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "MedicationSchedules",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "NumberOfPills",
                table: "MedicationSchedules",
                newName: "numberOfPills");

            migrationBuilder.RenameColumn(
                name: "MedicationId",
                table: "MedicationSchedules",
                newName: "medicationId");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "MedicationSchedules",
                newName: "duration");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationSchedules_UserId",
                table: "MedicationSchedules",
                newName: "IX_MedicationSchedules_userId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicationSchedules_MedicationId",
                table: "MedicationSchedules",
                newName: "IX_MedicationSchedules_medicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationSchedules_Medications_medicationId",
                table: "MedicationSchedules",
                column: "medicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationSchedules_Users_userId",
                table: "MedicationSchedules",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
