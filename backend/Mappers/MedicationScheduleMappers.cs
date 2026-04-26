
using backend.Dtos.MedicationDtos;
using backend.Dtos.MedicationScheduleDtos;
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
                EndDate=medicationScheduleModel.EndDate
            };
        }
            public static MedicationSchedule ToMedicationFromCreateDto(this CreateMedicationScheduleDto medicationScheduleDto,DateOnly endDate)
        {
            return new MedicationSchedule
            {
                UserId=medicationScheduleDto.UserId,
                MedicationId=medicationScheduleDto.MedicationId,
                NumberOfPills=medicationScheduleDto.NumberOfPills,
                Duration=medicationScheduleDto.Duration,
                StartDate=medicationScheduleDto.StartDate,
                
            
            };
        }
    }

}