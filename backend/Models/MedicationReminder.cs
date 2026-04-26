using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class MedicationReminder
    {
        [Key]
        public int Id {get; set;}

        public int? ReminderPlanningId{get;set;}
        public ReminderPlanning?  ReminderPlanning{get; set;}

        public TimeOnly ReminderHour{get;set;}    
    }
}