using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class MedicationReminder
    {
        private int Id{get; set;}

        private MedicationSchedule medicationSchedule{get; set;}=new MedicationSchedule();

        private TimeOnly reminderHour{get;set;}    
    }
}