using backend.Models;
namespace backend.Dtos.MedicationScheduleDtos
{
    public class CreateMedicationScheduleDto
    {
        public int? UserId{get;set;}
        public int? MedicationId{get; set;}

        public int NumberOfPills{get; set;}

        public int Duration{get; set;}

        public DateOnly StartDate{get; set;}

        public List<CreateReminderPlanningDto> ReminderPlannings{get; set;}
    }
}