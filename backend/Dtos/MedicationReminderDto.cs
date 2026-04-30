using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class MedicationReminderDto
    {
          public int Id{get; set;}
          public int? ReminderPlanningId{get;set;}
          public TimeOnly ReminderHour{get;set;}   

    }

}