using backend.Dtos.Medication;
using backend.Models;

namespace backend.Interfaces.MedicationInterfaces
{
    public interface IMedicationRepository
    {
        Task<List<Medication>> GetAllMedicationsAsync();
        Task<Medication?> GetMedicationByIdAsync(int id);

        Task<Medication> CreateMedicationAsync(Medication medicationModel);

        Task<Medication?> UpdateMedicationAsync(int id, CreateMedicationRequestDto medicationDto);

        Task<Medication?> DeleteMedicationAsync(int id);




    }
}