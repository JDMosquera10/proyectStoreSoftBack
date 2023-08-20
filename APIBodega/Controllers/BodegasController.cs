using APIBodega.Models.Repository;
using APIBodega.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBodega.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodegasController : ControllerBase
    {
        private IStoreRepository _StoreRepository;

        public BodegasController(IStoreRepository storeRepository)
        {
            _StoreRepository = storeRepository;
        }



        [HttpGet]
        [ActionName(nameof(GetBodegaAsync))]
        public IEnumerable<Bodega> GetBodegaAsync()
        {
            return _StoreRepository.GetBodega();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetBodegaById))]
        public ActionResult<Bodega> GetBodegaById(string id)
        {
            var bodegaByID = _StoreRepository.GetBodegaById(id);
            if (bodegaByID == null)
            {
                return NotFound();
            }
            return bodegaByID;
        }

        [HttpPost]
        [ActionName(nameof(CreateBodegaAsync))]
        public async Task<ActionResult<Bodega>> CreateBodegaAsync(Bodega bodega)
        {
            await _StoreRepository.CreateBodegaAsync(bodega);
            return CreatedAtAction(nameof(GetBodegaById), new { id = bodega.bo_cdgo }, bodega);
        }

        [HttpPut("{id}")]
        [ActionName(nameof(UpdateBodega))]
        public async Task<ActionResult> UpdateBodega(string id, Bodega bodega)
        {
            if (id != bodega.bo_cdgo)
            {
                return BadRequest();
            }

            await _StoreRepository.UpdateBodegaAsync(bodega);

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeleteBodega))]
        public async Task<IActionResult> DeleteBodega(string id)
        {
            var bodega = _StoreRepository.GetBodegaById(id);
            if (bodega == null)
            {
                return NotFound();
            }

            await _StoreRepository.DeleteBodegaAsync(bodega);

            return NoContent();
        }

    }
}
