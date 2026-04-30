using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using backend.Repository;

namespace backend.Services.Reminders
{
    public class MedicationReminderService : IMedicationReminderService
    {

        private readonly ApplicationDBContext _context;
        private readonly IMedicationReminderRepository _medicationReminderRepository;

        public MedicationReminderService(ApplicationDBContext context, IMedicationReminderRepository medicationReminderRepository)
        {
            _context=context;
            _medicationReminderRepository=medicationReminderRepository;
        }

        public async Task<MedicationReminder> CreateMedicationReminderAsync(MedicationReminder medicationReminderModel)
        {
            return await _medicationReminderRepository.CreateMedicationReminderAsync(medicationReminderModel);
        }

        public async Task<List<MedicationReminder>> GetAllMedicationRemindersAsync()
        {
           return await _medicationReminderRepository.GetAllMedicationRemindersAsync();
        }
    }
}