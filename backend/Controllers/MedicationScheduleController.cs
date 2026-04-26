

using backend.mappers;
using backend.Models;
using backend.Services.Schedule;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers{
    [Route("v1/medicationschedules")]
    [ApiController]
public class MedicationScheduleController: ControllerBase
    {
        private readonly IScheduleService _scheduleService;
        public MedicationScheduleController(IScheduleService scheduleService)
        {
            _scheduleService=scheduleService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSchedules()
        {
            var schedules= await _scheduleService.GetAllSchedulesAsync();
            var schedulesDto= schedules.Select(s=>s.ToMedicationScheduleDto());
            return Ok(schedulesDto);
        }

          [HttpGet("{id}")]
        public async Task<ActionResult<MedicationSchedule>> GetScheduleById([FromRoute] int id)
        {
            var schedule=await _scheduleService.GetMedicationScheduleAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return Ok(schedule.ToMedicationScheduleDto());
        }

    } 
  
}