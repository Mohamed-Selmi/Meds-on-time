using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class MedicationReminderRepository: IMedicationReminderRepository
    {
        private readonly ApplicationDBContext _context;
             public MedicationReminderRepository(ApplicationDBContext context)
        {
            _context=context;
        }

        public async Task<MedicationReminder> CreateMedicationReminderAsync(MedicationReminder medicationReminderModel)
        {
            await _context.MedicationReminders.AddAsync(medicationReminderModel);
            await _context.SaveChangesAsync();
            return medicationReminderModel;
        }

        public async Task<List<MedicationReminder>> GetAllMedicationRemindersAsync()
        {
            return await _context.MedicationReminders.ToListAsync();
        }
    }
}