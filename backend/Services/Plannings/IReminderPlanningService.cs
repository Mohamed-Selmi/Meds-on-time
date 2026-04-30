using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Services.Plannings
{
    public interface IReminderPlanningService
    {
        
        Task<ReminderPlanning> CreateReminderPlanningAsync(ReminderPlanning reminderPlanningModel);
        Task<List<ReminderPlanning>> GetAllReminderPlanningsAsync();
    }
}