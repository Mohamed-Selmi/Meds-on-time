using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class ReminderPlanningMapper
    {
        public static ReminderPlanningDto ToReminderPlanningDto(this ReminderPlanning reminderPlanningModel)
        {
            return new ReminderPlanningDto
            {
             Id=reminderPlanningModel.Id,
             reminderDay=reminderPlanningModel.reminderDay,
             MedicationScheduleId=reminderPlanningModel.MedicationScheduleId, 
             MedicationReminders=reminderPlanningModel.medicationReminders.Select(rp=>rp.ToMedicationReminderDto()).ToList()  
            };
        }
        public static ReminderPlanning ToReminderPlanningFromCreateDto(this CreateReminderPlanningDto reminderPlanningDto)
        {
            return new ReminderPlanning
            {
            reminderDay=reminderPlanningDto.reminderDay,
            MedicationScheduleId=reminderPlanningDto.MedicationScheduleId,
            
            };
        }
    }
}