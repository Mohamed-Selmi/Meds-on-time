using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class ReminderPlanning
    {
        [Key]
        public int Id{get; set;}

        public DateOnly reminderDay{get; set;}

        public string? dayOfWeek {get; set;}
        
        public MedicationSchedule medicationSchedule{get; set;}=new MedicationSchedule();

        public List<MedicationReminder> medicationReminders{get; set;}=new List<MedicationReminder>();

    
           
    }

}