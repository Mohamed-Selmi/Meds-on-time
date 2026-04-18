

using backend.Dtos.Medication;
using backend.Models;

namespace backend.Services.MedicationService
{
    
    public interface IMedicationService
    {
        Task<List<Medication>> GetAllMedications();
        Task<Medication?> GetMedicationById(int id);

        Task<Medication> CreateMedication(Medication medicationModel);

        Task<Medication?> UpdateMedication(int id, CreateMedicationRequestDto medicationDto);

        Task<Medication?> DeleteMedication(int id);
    }
}