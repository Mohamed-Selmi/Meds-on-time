


using backend.Dtos.MedicationDtos;
using backend.Models;

namespace backend.mappers
{
    public static class MedicationMappers
    {
    public static MedicationDto ToMedicationDto(this Medication medicationModel)
    {
        return new MedicationDto
        {
            Id=medicationModel.Id,
            Name=medicationModel.Name,
            Description=medicationModel.Description,
            Type=medicationModel.Type,
            SideEffects=medicationModel.SideEffects
        };
    }
    public static Medication ToMedicationFromCreateDto(this CreateMedicationRequestDto medicationDto)
        {
            return new Medication
            {
                Name=medicationDto.Name,
                Description=medicationDto.Description,
                Type=medicationDto.Type,
                SideEffects=medicationDto.SideEffects
            };
        }
    }
}