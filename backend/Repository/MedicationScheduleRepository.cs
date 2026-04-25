
using backend.Data;
using backend.Interfaces;
using backend.Models;

namespace backend.Repository
{
    public class MedicationScheduleRepository : IMedicationScheduleRepository
    {
        private readonly ApplicationDBContext _context;

        public MedicationScheduleRepository(ApplicationDBContext context)
        {
            _context=context;
        }

        public async Task<MedicationSchedule> CreateMedicationScheduleAsync(MedicationSchedule medicationScheduleModel)
        {
            await _context.MedicationSchedules.AddAsync(medicationScheduleModel);
            await _context.SaveChangesAsync();
            return medicationScheduleModel;
        }

        public Task<MedicationSchedule?> DeleteMedicationScheduleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicationSchedule>> GetAllSchedulesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicationSchedule>> GetAllUserMedicationSchedulesAsync(User User)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicationSchedule>> GetAllUserMedicationsForMedicineAsync(User user, Medication medication)
        {
            throw new NotImplementedException();
        }

        public Task<MedicationSchedule> GetMedicationScheduleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MedicationSchedule> UpdateMedicationScheduleAsync(int id, MedicationSchedule medicationScheduleModel)
        {
            throw new NotImplementedException();
        }
    }
}