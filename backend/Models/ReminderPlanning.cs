using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class ReminderPlanning
    {
        [Key]
        private int Id{get; set;}

        private DateOnly reminderDay{get; set;}

        private string dayOfWeek {get; set;}
        
        private MedicationSchedule medicationSchedule{get; set;}=new MedicationSchedule();

        private List<MedicationReminder> medicationReminders{get; set;}=new List<MedicationReminder>();

    
           
    }

}