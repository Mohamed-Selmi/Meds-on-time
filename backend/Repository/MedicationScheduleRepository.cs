
using backend.Data;
using backend.Dtos.MedicationScheduleDtos;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<MedicationSchedule?> DeleteMedicationScheduleAsync(MedicationSchedule medicationScheduleModel)
        {
           _context.MedicationSchedules.Remove(medicationScheduleModel);
           await _context.SaveChangesAsync();
           return medicationScheduleModel;

        }

        public async Task<List<MedicationSchedule>> GetAllSchedulesAsync()
        {
            return await _context.MedicationSchedules.ToListAsync();
        }

        public async Task<List<MedicationSchedule>> GetAllUserMedicationSchedulesAsync(User user)
        {
            return await _context.MedicationSchedules.ToListAsync();
        }

        public async Task<List<MedicationSchedule>> GetAllUserMedicationsForMedicineAsync(User user, Medication medication)
        {
           var allSchedules= await _context.MedicationSchedules.ToListAsync();
           return allSchedules.FindAll(x=>x.User==user && x.Medication==medication);
        }

        public async Task<MedicationSchedule?> GetMedicationScheduleAsync(int id)
        {
           return await _context.MedicationSchedules.FindAsync(id);
        }

        public async Task<MedicationSchedule?> UpdateMedicationScheduleAsync(int id, MedicationScheduleDto updateMedicationSchedule)
        {
            var scheduleExists= await _context.MedicationSchedules.FirstOrDefaultAsync(x=> x.Id==id);
            if (scheduleExists == null)
            {
                return null;
            }
                scheduleExists.UserId=updateMedicationSchedule.UserId;
                scheduleExists.MedicationId=updateMedicationSchedule.MedicationId;
                scheduleExists.NumberOfPills=updateMedicationSchedule.NumberOfPills;
                scheduleExists.Duration=updateMedicationSchedule.Duration;
                scheduleExists.StartDate=updateMedicationSchedule.StartDate;
                await _context.SaveChangesAsync();
                return scheduleExists;

                
        }
    }
}