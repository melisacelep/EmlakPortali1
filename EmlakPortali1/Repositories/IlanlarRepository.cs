
using EmlakPortali1.Models;

namespace EmlakPortali1.Repositories
{
    public class IlanlarRepository : GenericRepository<Ilan>
    {
        public IlanlarRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
