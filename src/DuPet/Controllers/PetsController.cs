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
        public async Task<ActionResult> AdicionarPet(Pet pet)
        {         
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("VisualizarDetalhesDoPet", new { id = pet.Id }, pet);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> VisualizarDetalhesDoPet(int idPet)
        {
            var pet = await _context.Pets
                .FirstOrDefaultAsync(c => c.Id == idPet);

            if (pet == null) return NotFound();


            return Ok(pet);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditarPet(int id, Pet pet)
        {

            if (id != pet.Id) return BadRequest();

            var modeloDb = await _context.Pets.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (modeloDb == null) return NotFound();

            _context.Pets.Update(pet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoverPet(int idPet)
        {
            var pet = await _context.Pets.FindAsync(idPet);

            if (pet == null) return NotFound();

            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
