using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class reminderstructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicationSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userId = table.Column<int>(type: "integer", nullable: false),
                    medicationId = table.Column<int>(type: "integer", nullable: false),
                    numberOfPills = table.Column<int>(type: "integer", nullable: false),
                    duration = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicationSchedules_Medications_medicationId",
                        column: x => x.medicationId,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicationSchedules_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReminderPlannings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reminderDay = table.Column<DateOnly>(type: "date", nullable: false),
                    medicationScheduleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReminderPlannings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReminderPlannings_MedicationSchedules_medicationScheduleId",
                        column: x => x.medicationScheduleId,
                        principalTable: "MedicationSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicationReminders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    medicationScheduleId = table.Column<int>(type: "integer", nullable: false),
                    reminderHour = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    ReminderPlanningId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationReminders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicationReminders_MedicationSchedules_medicationScheduleId",
                        column: x => x.medicationScheduleId,
                        principalTable: "MedicationSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicationReminders_ReminderPlannings_ReminderPlanningId",
                        column: x => x.ReminderPlanningId,
                        principalTable: "ReminderPlannings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicationReminders_medicationScheduleId",
                table: "MedicationReminders",
                column: "medicationScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationReminders_ReminderPlanningId",
                table: "MedicationReminders",
                column: "ReminderPlanningId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationSchedules_medicationId",
                table: "MedicationSchedules",
                column: "medicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationSchedules_userId",
                table: "MedicationSchedules",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_ReminderPlannings_medicationScheduleId",
                table: "ReminderPlannings",
                column: "medicationScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicationReminders");

            migrationBuilder.DropTable(
                name: "ReminderPlannings");

            migrationBuilder.DropTable(
                name: "MedicationSchedules");
        }
    }
}
