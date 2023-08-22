namespace APIBodega.Models.Repository
{
    public interface IStoreRepository
    {
        Task<Bodega> CreateBodegaAsync(Bodega bodega);
        Task<bool> DeleteBodegaAsync(Bodega bodega);
        Bodega GetBodegaById(string id);
        IEnumerable<Bodega> GetBodega();
        Task<bool> UpdateBodegaAsync(Bodega bodega);
    }
}
