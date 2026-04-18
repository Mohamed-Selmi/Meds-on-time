using backend.Data;
using backend.Dtos.Medication;
using backend.Interfaces.MedicationInterfaces;
using backend.Models;

namespace backend.Services.MedicationService
{
    
    public class MedicationService: IMedicationService
    {
    private readonly ApplicationDBContext _context;

    private readonly IMedicationRepository _medicationRepository;

    public MedicationService(ApplicationDBContext context,IMedicationRepository medicationRepository)
        {
          _context=context;
          _medicationRepository=medicationRepository;
        }

        public async Task<Medication> CreateMedication(Medication medicationModel)
        {
            return await _medicationRepository.CreateMedicationAsync(medicationModel);
        }

        public async Task<Medication?> DeleteMedication(int id)
        {
             return await _medicationRepository.DeleteMedicationAsync(id);
        }

        public async Task<List<Medication>> GetAllMedications()
        {
            return await _medicationRepository.GetAllMedicationsAsync();
        }

        public async Task<Medication?> GetMedicationById(int id)
        {
            return await _medicationRepository.GetMedicationByIdAsync(id);
        }

        public async Task<Medication?> UpdateMedication(int id, CreateMedicationRequestDto medicationDto)
        {
            return await _medicationRepository.UpdateMedicationAsync(id,medicationDto);
        }
    }
}