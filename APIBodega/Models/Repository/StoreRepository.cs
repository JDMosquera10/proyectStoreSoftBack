using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;

namespace APIBodega.Models.Repository
{
    public class StoreRepository : IStoreRepository
    {
        protected readonly BodegaContext _context;
        public StoreRepository(BodegaContext context) => _context = context;

        public IEnumerable<Bodega> GetBodega()
        {
            return _context.bdga.ToList();
        }

        public Bodega GetBodegaById(string id)
        {
            return _context.bdga.Find(id);
        }
        public async Task<Bodega> CreateBodegaAsync(Bodega bodega)
        {
            var bodegasArr = GetBodega();
            if (bodegasArr.Count() > 0)
            {
                int ultNumber = 0;
                foreach (Bodega IStore in bodegasArr)
                {
                    int latNumber = Convert.ToInt32(IStore.bo_cdgo.Substring(4));
                    if (latNumber > ultNumber)
                    {
                        ultNumber = latNumber;
                    }
                }
                int nextNumber = ultNumber + 1;
                bodega.bo_cdgo = "bdo_"+ nextNumber + "";
                var result = await _context.Set<Bodega>().AddAsync(bodega);
                var result2 = await _context.SaveChangesAsync();
                return bodega;
            }
            else
            {
                bodega.bo_cdgo = "bdo_1";
                var result = await _context.Set<Bodega>().AddAsync(bodega);
                var result2 = await _context.SaveChangesAsync();
                return bodega;
            }
        }

        public async Task<bool> UpdateBodegaAsync(Bodega bodega)
        {
            _context.Entry(bodega).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteBodegaAsync(Bodega bodega)
        {
            //var entity = await GetByIdAsync(id);
            if (bodega is null)
            {
                return false;
            }
            _context.Set<Bodega>().Remove(bodega);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
