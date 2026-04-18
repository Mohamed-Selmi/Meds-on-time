using backend.Dtos.Medication;
using backend.Models;

namespace backend.Interfaces
{
    public interface IMedicationScheduleRepository
    {
        Task<List<MedicationSchedule>> getAllSchedulesAsync();
        Task<MedicationSchedule> GetMedicationScheduleAsync(int id);

        Task<List<MedicationSchedule>> GetAllUserMedicationSchedulesAsync(User User);

        Task<List<MedicationSchedule>> GetAllUserMedicationsForMedicineAsync(User user, Medication medication);

        


    }
}