using backend.Dtos.Medication;
using backend.Models;

namespace backend.Interfaces
{
    public interface IMedicationScheduleRepository
    {
        Task<List<MedicationSchedule>> GetAllSchedulesAsync();
        Task<MedicationSchedule> GetMedicationScheduleAsync(int id);

        Task<MedicationSchedule> CreateMedicationScheduleAsync(MedicationSchedule medicationScheduleModel);

        Task<MedicationSchedule> UpdateMedicationScheduleAsync(int id,MedicationSchedule medicationScheduleModel);

        Task<MedicationSchedule?> DeleteMedicationScheduleAsync(int id); 

        Task<List<MedicationSchedule>> GetAllUserMedicationSchedulesAsync(User User);

        Task<List<MedicationSchedule>> GetAllUserMedicationsForMedicineAsync(User user, Medication medication);

        


    }
}