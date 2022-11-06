using DuPet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DuPet.Controllers
{
    [Authorize(Roles = "Administrador,Usuario")]
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

            return CreatedAtAction("VisualizarDetalhesDoPet", new { idPet = pet.Id }, pet);
        }

        [HttpGet("{idPet}")]
        public async Task<ActionResult> VisualizarDetalhesDoPet(int idPet)
        {
            var pet = await _context.Pets
                .Include(t => t.Usuarios).ThenInclude(t => t.Usuario)
                .Include(t => t.Doses)
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

        [HttpPost("{id}/usuarios")]
        public async Task<ActionResult> AdicionarUsuario(int id, PetUsuarios model) {
            if (id != model.PetId) return BadRequest();
            _context.PetsUsuarios.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("VisualizarDetalhesDoPet", new { id = model.PetId }, model);
        }

        [HttpDelete("{id}/usuarios/{usuarioId}")]
        public async Task<ActionResult> RemoverUsuario(int id, int usuarioId) {

            var model = await _context.PetsUsuarios
                .Where(c => c.PetId == id && c.UsuarioId == usuarioId)
                .FirstOrDefaultAsync();

            if (model == null) return NotFound();

            _context.PetsUsuarios.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
