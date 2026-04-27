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
    public class ReminderPlanningRepository : IReminderPlanningRepository
    {

          private readonly ApplicationDBContext _context;

        public ReminderPlanningRepository(ApplicationDBContext context)
        {
            _context=context;
        }
        public async Task<ReminderPlanning> CreateReminderPlanningAsync(ReminderPlanning reminderPlanningModel)
        {
             await _context.ReminderPlannings.AddAsync(reminderPlanningModel);
            await _context.SaveChangesAsync();
            return reminderPlanningModel;
        }

        public async Task<List<ReminderPlanning>> GetAllReminderPlanningsAsync()
        {
            return await _context.ReminderPlannings.ToListAsync();
        }
    }
}