using _21100744PARCIALWEB.Entities;
using _21100744PARCIALWEB.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _21100744PARCIALWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {
        private readonly ICompetencyRepository _competencyRepository;

        public CompetencyController(ICompetencyRepository competencyRepository)
        {
            _competencyRepository = competencyRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var attendees = await _competencyRepository.GetAll();
            return Ok(attendees);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] Competency competencies)
        {
            int attendeesID = await _competencyRepository.Insert(competencies);
            return Ok(attendeesID);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Competency competencies)
        {
            if (id != competencies.Id) return BadRequest();
            var result = await _competencyRepository.Update(competencies);
            if (!result) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _competencyRepository.Delete(id);
            if (!result) return NotFound();
            return Ok(result);
        }
    }
}
