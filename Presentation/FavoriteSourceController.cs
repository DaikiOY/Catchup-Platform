using CatchupPlatform.Application.UseCases;
using CatchupPlatform.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatchupPlatform.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoriteSourceController : ControllerBase
    {
        private readonly FavoriteSourceService _service;

        public FavoriteSourceController(FavoriteSourceService service)
        {
            _service = service;
        }

        // Obtener todas las fuentes favoritas
        [HttpGet]
        public async Task<IEnumerable<FavoriteSource>> GetAll()
        {
            return await _service.GetAllFavoriteSourcesAsync();
        }

        // Obtener una fuente favorita por ID
        [HttpGet("{id}")]
        public async Task<ActionResult<FavoriteSource>> GetById(int id)
        {
            var source = await _service.GetFavoriteSourceByIdAsync(id);
            if (source == null)
                return NotFound();
            return Ok(source);
        }

        // Agregar una nueva fuente favorita
        [HttpPost]
        public async Task<ActionResult<FavoriteSource>> Add([FromBody] FavoriteSource source)
        {
            var newSource = await _service.AddFavoriteSourceAsync(source.Name, source.Url);
            return CreatedAtAction(nameof(GetById), new { id = newSource.Id }, newSource);
        }

        // Actualizar una fuente favorita existente
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] FavoriteSource source)
        {
            var updatedSource = await _service.UpdateFavoriteSourceAsync(id, source.Name, source.Url);
            if (updatedSource == null)
                return NotFound();
            return NoContent();
        }

        // Eliminar una fuente favorita
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteFavoriteSourceAsync(id);
            return NoContent();
        }
    }
}
