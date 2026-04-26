using backend.Models;
namespace backend.Dtos.MedicationScheduleDtos
{
    public class MedicationScheduleDto
    {
        public int Id{get; set;}
        public int? UserId{get;set;}
        public int? MedicationId{get; set;}

        public int NumberOfPills{get; set;}

        public int Duration{get; set;}

        public DateOnly StartDate{get; set;}


        public DateOnly? EndDate{get; set;}
    }
}