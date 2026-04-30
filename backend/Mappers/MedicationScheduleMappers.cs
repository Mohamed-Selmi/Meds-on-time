
using backend.Dtos.MedicationDtos;
using backend.Dtos.MedicationScheduleDtos;
using backend.Mappers;
using backend.Models;

namespace backend.mappers
{
    public static class MedicationScheduleMappers
    {
        public static MedicationScheduleDto ToMedicationScheduleDto(this MedicationSchedule medicationScheduleModel)
        {
            return new MedicationScheduleDto
            {
                Id=medicationScheduleModel.Id,
                UserId=medicationScheduleModel.UserId,
                MedicationId=medicationScheduleModel.MedicationId,
                NumberOfPills=medicationScheduleModel.NumberOfPills,
                Duration=medicationScheduleModel.Duration,
                StartDate=medicationScheduleModel.StartDate,
                EndDate=medicationScheduleModel.EndDate,
                ReminderPlannings=medicationScheduleModel.ReminderPlannings.Select(rp=>rp.ToReminderPlanningDto()).ToList()
            };
        }
            public static MedicationSchedule ToMedicationScheduleFromCreateDto(this CreateMedicationScheduleDto medicationScheduleDto)
        {
            if (medicationScheduleDto.ReminderHours.Count != medicationScheduleDto.NumberOfPills)
            {
                throw new ArgumentException($"Reminder hours count ({medicationScheduleDto.ReminderHours}) must match number of pills ({medicationScheduleDto.NumberOfPills})");
            }
           var medSchedule= new MedicationSchedule
            {
                UserId=medicationScheduleDto.UserId,
                MedicationId=medicationScheduleDto.MedicationId,
                NumberOfPills=medicationScheduleDto.NumberOfPills,
                Duration=medicationScheduleDto.Duration,
                StartDate=medicationScheduleDto.StartDate,
                EndDate=medicationScheduleDto.StartDate.AddDays(medicationScheduleDto.Duration-1),
                ReminderPlannings=new List<ReminderPlanning>()            
            };
            for (int i=0; i < medicationScheduleDto.Duration; i++)
            {
                var day=medicationScheduleDto.StartDate.AddDays(i);
                medSchedule.ReminderPlannings.Add(new ReminderPlanning
                {
                    reminderDay=day,
                    dayOfWeek=day.DayOfWeek.ToString(),
                    medicationReminders=medicationScheduleDto.ReminderHours.Select(hour=>new MedicationReminder
                    {
                        ReminderHour=hour
                    }).ToList()
                });
            }
            return medSchedule;
        }
    }

}