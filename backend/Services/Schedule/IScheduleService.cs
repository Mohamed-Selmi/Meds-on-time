using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.MedicationScheduleDtos;
using backend.Models;

namespace backend.Services.Schedule
{
    public interface IScheduleService
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