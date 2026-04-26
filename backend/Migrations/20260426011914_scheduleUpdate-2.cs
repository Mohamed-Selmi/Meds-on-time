using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class scheduleUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicationReminders_MedicationSchedules_medicationScheduleId",
                table: "MedicationReminders");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationSchedules_Medications_MedicationId",
                table: "MedicationSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationSchedules_Users_UserId",
                table: "MedicationSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_ReminderPlannings_MedicationSchedules_medicationScheduleId",
                table: "ReminderPlannings");

            migrationBuilder.DropIndex(
                name: "IX_MedicationReminders_medicationScheduleId",
                table: "MedicationReminders");

            migrationBuilder.DropColumn(
                name: "medicationScheduleId",
                table: "MedicationReminders");

            migrationBuilder.RenameColumn(
                name: "medicationScheduleId",
                table: "ReminderPlannings",
                newName: "MedicationScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_ReminderPlannings_medicationScheduleId",
                table: "ReminderPlannings",
                newName: "IX_ReminderPlannings_MedicationScheduleId");

            migrationBuilder.RenameColumn(
                name: "reminderHour",
                table: "MedicationReminders",
                newName: "ReminderHour");

            migrationBuilder.AlterColumn<int>(
                name: "MedicationScheduleId",
                table: "ReminderPlannings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MedicationSchedules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MedicationId",
                table: "MedicationSchedules",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "MedicationScheduleDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    MedicationId = table.Column<int>(type: "integer", nullable: false),
                    NumberOfPills = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationScheduleDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicationScheduleDto_Medications_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicationScheduleDto_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicationScheduleDto_MedicationId",
                table: "MedicationScheduleDto",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationScheduleDto_UserId",
                table: "MedicationScheduleDto",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationSchedules_Medications_MedicationId",
                table: "MedicationSchedules",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationSchedules_Users_UserId",
                table: "MedicationSchedules",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReminderPlannings_MedicationSchedules_MedicationScheduleId",
                table: "ReminderPlannings",
                column: "MedicationScheduleId",
                principalTable: "MedicationSchedules",
                principalColumn: "Id");
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

            migrationBuilder.DropForeignKey(
                name: "FK_ReminderPlannings_MedicationSchedules_MedicationScheduleId",
                table: "ReminderPlannings");

            migrationBuilder.DropTable(
                name: "MedicationScheduleDto");

            migrationBuilder.RenameColumn(
                name: "MedicationScheduleId",
                table: "ReminderPlannings",
                newName: "medicationScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_ReminderPlannings_MedicationScheduleId",
                table: "ReminderPlannings",
                newName: "IX_ReminderPlannings_medicationScheduleId");

            migrationBuilder.RenameColumn(
                name: "ReminderHour",
                table: "MedicationReminders",
                newName: "reminderHour");

            migrationBuilder.AlterColumn<int>(
                name: "medicationScheduleId",
                table: "ReminderPlannings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MedicationSchedules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicationId",
                table: "MedicationSchedules",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "medicationScheduleId",
                table: "MedicationReminders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MedicationReminders_medicationScheduleId",
                table: "MedicationReminders",
                column: "medicationScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationReminders_MedicationSchedules_medicationScheduleId",
                table: "MedicationReminders",
                column: "medicationScheduleId",
                principalTable: "MedicationSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ReminderPlannings_MedicationSchedules_medicationScheduleId",
                table: "ReminderPlannings",
                column: "medicationScheduleId",
                principalTable: "MedicationSchedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
