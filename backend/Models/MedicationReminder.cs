using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class MedicationReminder
    {
        [Key]
        public int Id {get; set;}

        public MedicationSchedule medicationSchedule {get; set;}=new MedicationSchedule();

        public TimeOnly reminderHour{get;set;}    
    }
}