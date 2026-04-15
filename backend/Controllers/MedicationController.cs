
using backend.Data;
using backend.Dtos.Medication;
using backend.Interfaces.MedicationInterfaces;
using backend.mappers;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers{

[Route("v1/medications")]
[ApiController]
    public class MedicationController : ControllerBase
    {
          private readonly ApplicationDBContext _context;
        private readonly IMedicationRepository _medicationRepository;
        public MedicationController(ApplicationDBContext context,IMedicationRepository medicationRepository)
        {
          _context=context;
          _medicationRepository=medicationRepository;
        }
         
    
        [HttpGet]
        public async Task<IActionResult> GetAllMedications()
            {
                var medications= await _medicationRepository.GetAllMedicationsAsync();
                var medicationDto=medications.Select(m=>m.ToMedicationDto());

                return Ok(medications);
            }
        [HttpGet("{id}")]
        public async Task<ActionResult<Medication>> GetMedicationById(int id)
        {
            var medication= await _medicationRepository.GetMedicationByIdAsync(id);
            if (medication == null)
            {
                return NotFound();
            }
            return Ok(medication.ToMedicationDto());
        }
        [HttpPost]
        public async Task<IActionResult> CreateMedication([FromBody] CreateMedicationRequestDto medicationDto)
        {
            var medicationModel= medicationDto.ToMedicationFromCreateDto();
            await _medicationRepository.CreateMedicationAsync(medicationModel);
            return CreatedAtAction(nameof(GetMedicationById),new {id=medicationModel.Id},medicationModel.ToMedicationDto());
        }

        [HttpPut]
        [Route("id")]
        public async Task<IActionResult> UpdateMedication([FromRoute] int id, [FromBody] CreateMedicationRequestDto UpdateMedicationDto)
        {
            var medicationModel= await _medicationRepository.UpdateMedicationAsync(id,UpdateMedicationDto);
            if (medicationModel == null)
                {
                    return NotFound();
                }
            return Ok(medicationModel.ToMedicationDto());
        }

        [HttpDelete]
        [Route("id")]

        public async Task<IActionResult> DeleteMedication([FromRoute] int id)
        {
            var medicationModel=await _medicationRepository.DeleteMedicationAsync(id);
            if (medicationModel == null)
                    {
                        return NotFound();
                    }
                return NoContent();
        }
    


}
}
