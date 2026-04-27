
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
            return new MedicationSchedule
            {
                UserId=medicationScheduleDto.UserId,
                MedicationId=medicationScheduleDto.MedicationId,
                NumberOfPills=medicationScheduleDto.NumberOfPills,
                Duration=medicationScheduleDto.Duration,
                StartDate=medicationScheduleDto.StartDate,
                ReminderPlannings=medicationScheduleDto.ReminderPlannings.ConvertAll(rp=>rp.ToReminderPlanningFromCreateDto()).ToList()
            
            };
        }
    }

}