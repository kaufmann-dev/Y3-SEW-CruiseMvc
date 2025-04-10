using Model.Configuration;
using Model.Entity;

namespace Domain.Repository
{
    public class CruiseRepository : ARepository<Cruise>, ICruiseRepository 
    {
        
        public CruiseRepository(CruiseDbContext cruiseDbContext) : base(cruiseDbContext) 
        {
        }
    }
}