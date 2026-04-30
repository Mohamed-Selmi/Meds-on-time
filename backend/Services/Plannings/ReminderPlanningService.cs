using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using backend.Repository;

namespace backend.Services.Plannings
{
    public class ReminderPlanningService : IReminderPlanningService
    {
                private readonly ApplicationDBContext _context;
                private readonly IReminderPlanningRepository _reminderPlanningRepository;

                public ReminderPlanningService(ApplicationDBContext context,IReminderPlanningRepository reminderPlanningRepository)
                {
                    _context=context;
                    _reminderPlanningRepository=reminderPlanningRepository;
                }

        public async Task<ReminderPlanning> CreateReminderPlanningAsync(ReminderPlanning reminderPlanningModel)
        {
            return await _reminderPlanningRepository.CreateReminderPlanningAsync(reminderPlanningModel);
        }

        public async Task<List<ReminderPlanning>> GetAllReminderPlanningsAsync()
        {
            return await _reminderPlanningRepository.GetAllReminderPlanningsAsync();
        }
    }
}