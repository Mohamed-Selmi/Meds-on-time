namespace backend.Dtos.Medication
{
    public class CreateMedicationRequestDto{

        public string Name {get; set;}= string.Empty;
        public string? Description {get; set;}

        public string? Type {get; set;}

        public string? SideEffects{get; set;}
    }
}