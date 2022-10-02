using DuPet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DuPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PetsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarPet(Pet model)
        {         
            _context.Pets.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("VisualizarDetalhesDoPet", new { id = model.Id }, model);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> VisualizarDetalhesDoPet(int id)
        {
            var model = await _context.Pets
                .FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) return NotFound();


            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditarPet(int id, Pet model)
        {

            if (id != model.Id) return BadRequest();

            var modeloDb = await _context.Pets.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (modeloDb == null) return NotFound();

            _context.Pets.Update(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverPet(int id)
        {
            var model = await _context.Pets.FindAsync(id);

            if (model == null) return NotFound();

            _context.Pets.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
