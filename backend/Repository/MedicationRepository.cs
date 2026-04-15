


using backend.Dtos.Medication;
using backend.Interfaces.MedicationInterfaces;
using backend.Models;
using backend.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class MedicationRepository : IMedicationRepository
    {
        private readonly ApplicationDBContext _context;
        public MedicationRepository(ApplicationDBContext context)
        {
            _context= context;
        }
        public async Task<Medication> CreateMedicationAsync(Medication medicationModel)
        {
           await _context.Medications.AddAsync(medicationModel);
           await _context.SaveChangesAsync();
           return medicationModel;
        }

        public async Task<Medication?> DeleteMedicationAsync(int id)
        {
            var medicationExists= await _context.Medications.FirstOrDefaultAsync(x=>x.Id==id);
            if (medicationExists == null)
            {
                return null;
            }
            _context.Medications.Remove(medicationExists);
            await _context.SaveChangesAsync();
            return medicationExists;
        }

        public async Task<List<Medication>> GetAllMedicationsAsync()
        {
            return await _context.Medications.ToListAsync();
        }

        public async Task<Medication?> GetMedicationByIdAsync(int id)
        {
            return await _context.Medications.FindAsync(id);

        }

        public async Task<Medication?> UpdateMedicationAsync(int id, CreateMedicationRequestDto medicationDto)
        {
             var medicationExists= await _context.Medications.FirstOrDefaultAsync(x=>x.Id==id);
            if (medicationExists == null)
            {
                return null;
            }
            medicationExists.Name=medicationDto.Name;
            medicationExists.Description=medicationDto.Description;
            medicationExists.Type=medicationDto.Type;
            medicationExists.SideEffects=medicationDto.SideEffects;
            await _context.SaveChangesAsync();
            return medicationExists;
        }
    }

}