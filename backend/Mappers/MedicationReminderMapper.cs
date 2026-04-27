using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class MedicationReminderMapper
    {
        public static MedicationReminderDto ToMedicationReminderDto(this MedicationReminder medicationReminderModel)
        {
            return new MedicationReminderDto
            {
                Id=medicationReminderModel.Id,
                ReminderPlanningId=medicationReminderModel.ReminderPlanningId,
                ReminderHour=medicationReminderModel.ReminderHour,
            };
        }
        public static MedicationReminder ToMedicationFromCreateReminderDto(this CreateMedicationReminderDto medicationReminderDto)
        {
            return new MedicationReminder
            {
                ReminderPlanningId=medicationReminderDto.ReminderPlanningId,
                ReminderHour=medicationReminderDto.ReminderHour,
            };
        }
    }
}