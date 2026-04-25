
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
                User=medicationScheduleModel.User,
                Medication=medicationScheduleModel.Medication,
                NumberOfPills=medicationScheduleModel.NumberOfPills,
                Duration=medicationScheduleModel.Duration,
                StartDate=medicationScheduleModel.StartDate,
                EndDate=medicationScheduleModel.EndDate
            };
        }
            public static MedicationSchedule ToMedicationFromCreateDto(this CreateMedicationScheduleDto medicationScheduleDto)
        {
            return new MedicationSchedule
            {
                User=medicationScheduleDto.User,
                Medication=medicationScheduleDto.Medication,
                NumberOfPills=medicationScheduleDto.NumberOfPills,
                Duration=medicationScheduleDto.Duration,
                StartDate=medicationScheduleDto.StartDate,
                
            
            };
        }
    }

}