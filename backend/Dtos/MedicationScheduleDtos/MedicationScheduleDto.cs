using backend.Models;
namespace backend.Dtos.MedicationScheduleDtos
{
    public class MedicationScheduleDto
    {
        public int Id{get; set;}

        public User User{get; set;}=null!;

        public Medication Medication{get; set;}=null!;

        public int NumberOfPills{get; set;}

        public int Duration{get; set;}

        public DateOnly? StartDate{get; set;}

        public DateOnly? EndDate{get; set;}
    }
}