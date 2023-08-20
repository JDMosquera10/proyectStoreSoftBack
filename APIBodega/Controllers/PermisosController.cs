using APIBodega.Models.Repository;
using APIBodega.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBodega.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisosController : ControllerBase
    {
        private IPermissRepository _PermissRepository;

        public PermisosController(IPermissRepository storeRepository)
        {
            _PermissRepository = storeRepository;
        }

        [HttpGet]
        [ActionName(nameof(GetPermisoAsync))]
        public IEnumerable<Permisos> GetPermisoAsync()
        {
            return _PermissRepository.GetPermisos();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetPermisoById))]
        public ActionResult<Permisos> GetPermisoById(int id)
        {
            var permisoByID = _PermissRepository.GetPermisosById(id);
            if (permisoByID == null)
            {
                return NotFound();
            }
            return permisoByID;
        }

        [HttpPost]
        [ActionName(nameof(CreatePermisoAsync))]
        public async Task<ActionResult<Permisos>> CreatePermisoAsync(Permisos permiso)
        {
            await _PermissRepository.CreatePermisosAsync(permiso);
            return CreatedAtAction(nameof(GetPermisoById), new { id = permiso.up_rowid }, permiso);
        }

        [HttpPut("{id}")]
        [ActionName(nameof(UpdatePermiso))]
        public async Task<ActionResult> UpdatePermiso(int id, Permisos permiso)
        {
            if (id != permiso.up_rowid)
            {
                return BadRequest();
            }

            await _PermissRepository.UpdatePermisosAsync(permiso);

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeletePermiso))]
        public async Task<IActionResult> DeletePermiso(int id)
        {
            var permiso = _PermissRepository.GetPermisosById(id);
            if (permiso == null)
            {
                return NotFound();
            }

            await _PermissRepository.DeletePermisosAsync(permiso);

            return NoContent();
        }

    }
}
