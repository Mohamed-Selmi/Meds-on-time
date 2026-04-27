using backend.Dtos.MedicationDtos;
using backend.Dtos.MedicationScheduleDtos;
using backend.Models;

namespace backend.Interfaces
{
    public interface IMedicationScheduleRepository
    {
        Task<List<MedicationSchedule>> GetAllSchedulesAsync();
        Task<MedicationSchedule?> GetMedicationScheduleAsync(int id);

        Task<MedicationSchedule> CreateMedicationScheduleAsync(MedicationSchedule medicationScheduleModel);
        

        Task<MedicationSchedule?> UpdateMedicationScheduleAsync(int id,MedicationScheduleDto updateMedicationSchedule);

        Task<MedicationSchedule?> DeleteMedicationScheduleAsync(MedicationSchedule medicationScheduleModel); 

        Task<List<MedicationSchedule>> GetAllUserMedicationSchedulesAsync(User User);

        Task<List<MedicationSchedule>> GetAllUserMedicationsForMedicineAsync(User user, Medication medication);

        


    }
}