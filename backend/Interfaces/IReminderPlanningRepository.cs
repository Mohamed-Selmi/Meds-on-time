using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Interfaces
{
    public interface IReminderPlanningRepository
    {
        Task<ReminderPlanning> CreateReminderPlanningAsync(ReminderPlanning reminderPlanningModel);
        Task<List<ReminderPlanning>> GetAllReminderPlanningsAsync();
    }
}