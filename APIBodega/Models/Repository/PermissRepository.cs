using Microsoft.EntityFrameworkCore;

namespace APIBodega.Models.Repository
{
    public class PermissRepository : IPermissRepository
    {
        protected readonly BodegaContext _context;
        public PermissRepository(BodegaContext context) => _context = context;

        public IEnumerable<Permisos> GetPermisos()
        {
            return _context.usrio_prmso.ToList();
        }

        public Permisos GetPermisosById(int id)
        {
            return _context.usrio_prmso.Find(id);
        }
        public async Task<Permisos> CreatePermisosAsync(Permisos permiso)
        {
            var result = await _context.Set<Permisos>().AddAsync(permiso);
            var result2 = await _context.SaveChangesAsync();
            return permiso;
        }

        public async Task<bool> UpdatePermisosAsync(Permisos permiso)
        {
            _context.Entry(permiso).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePermisosAsync(Permisos permiso)
        {
            //var entity = await GetByIdAsync(id);
            if (permiso is null)
            {
                return false;
            }
            _context.Set<Permisos>().Remove(permiso);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
