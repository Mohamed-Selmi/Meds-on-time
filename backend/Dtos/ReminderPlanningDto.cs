using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class ReminderPlanningDto
    {
        public int Id{get; set;}
        public DateOnly reminderDay{get; set;}

        public int? MedicationScheduleId{get;set;}

        public List<MedicationReminderDto> MedicationReminders{get; set;}
    }
}