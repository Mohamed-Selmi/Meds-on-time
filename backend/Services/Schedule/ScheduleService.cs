using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.MedicationScheduleDtos;
using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace backend.Services.Schedule
{
    public class ScheduleService : IScheduleService
    {
        private readonly ApplicationDBContext _context;
        private readonly IMedicationScheduleRepository _scheduleRepository;
        public ScheduleService(ApplicationDBContext context,IMedicationScheduleRepository scheduleRepository)
        {
            _context=context;
            _scheduleRepository=scheduleRepository;
        }
        public async Task<MedicationSchedule> CreateMedicationScheduleAsync(MedicationSchedule medicationScheduleModel)
        {

            //literally high fived myself when this worked. Been stressing about how to do it for so long.
            //I think looping via the duration number and calling the Reminderplanning service is the way to go.
            //In the reminderPlanning service I'll do the same but this time using how many pills a day.
            //medicationScheduleModel.EndDate=medicationScheduleModel.StartDate.AddDays(medicationScheduleModel.Duration);

            return await _scheduleRepository.CreateMedicationScheduleAsync(medicationScheduleModel);
            
        }
        

        public Task<MedicationSchedule?> DeleteMedicationScheduleAsync(MedicationSchedule medicationScheduleModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MedicationSchedule>> GetAllSchedulesAsync()
        {
            return await _scheduleRepository.GetAllSchedulesAsync();
        }

        public Task<List<MedicationSchedule>> GetAllUserMedicationSchedulesAsync(User User)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicationSchedule>> GetAllUserMedicationsForMedicineAsync(User user, Medication medication)
        {
            throw new NotImplementedException();
        }

        public async Task<MedicationSchedule?> GetMedicationScheduleAsync(int id)
        {
            return await _scheduleRepository.GetMedicationScheduleAsync(id);

        }

        public Task<MedicationSchedule?> UpdateMedicationScheduleAsync(int id, MedicationScheduleDto updateMedicationSchedule)
        {
            throw new NotImplementedException();
        }
    }
}