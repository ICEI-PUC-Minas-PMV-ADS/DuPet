using DuPet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DuPet.Controllers {

    [Authorize(Roles = "Administrador,Usuario")]
    [Route("api/[controller]")]
    [ApiController]
    public class DosesController : ControllerBase {
        private readonly AppDbContext _context;

        public DosesController(AppDbContext context) {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarDose(Dose model) {
            _context.Doses.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("VisualizarDetalhesDaDose", new { id = model.Id }, model);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> VisualizarDetalhesDaDose(int id) {
            var model = await _context.Doses
                .FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) return NotFound();


            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditarDose(int id, Dose model) {

            if (id != model.Id) return BadRequest();

            var modeloDb = await _context.Doses.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (modeloDb == null) return NotFound();

            _context.Doses.Update(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverDose(int id) {
            var model = await _context.Doses.FindAsync(id);

            if (model == null) return NotFound();

            _context.Doses.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
