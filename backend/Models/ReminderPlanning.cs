using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class ReminderPlanning
    {
        [Key]
        public int Id{get; set;}

        public DateOnly reminderDay{get; set;}

        public string? dayOfWeek {get; set;}

        public int? MedicationScheduleId{get;set;}
        
        public MedicationSchedule MedicationSchedule{get; set;}=new MedicationSchedule();

        public List<MedicationReminder> medicationReminders{get; set;}=new List<MedicationReminder>();

    
           
    }

}