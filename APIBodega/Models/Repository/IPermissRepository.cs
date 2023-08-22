namespace APIBodega.Models.Repository
{
    public interface IPermissRepository
    {
        Task<Permisos> CreatePermisosAsync(Permisos permiso);
        Task<bool> DeletePermisosAsync(Permisos permiso);
        Permisos GetPermisosById(int id);
        IEnumerable<Permisos> GetPermisos();
        Task<bool> UpdatePermisosAsync(Permisos permiso);
    }
}
