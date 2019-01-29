using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Data;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> repository;
        public RegionService(IRepository<Region> repository)
        {
            this.repository = repository;
        }
        public void Delete(int id)
        {
            var regionToDelete = repository.Find(id);
            if (regionToDelete != null) {
                repository.Delete(regionToDelete);
            }
        }

        public Region Find(int id)
        {
            return repository.Find(id);
        }

        public Region Find(Expression<Func<Region, bool>> where)
        {
            return repository.Find(where);
        }

        public Region FindByName(string name)
        {
            return repository.Find(r => r.Name.Contains(name));
        }

        public IEnumerable<Region> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<Region> GetAll(Expression<Func<Region, bool>> where)
        {
            return repository.GetAll(where);
        }

        public void Insert(Region region)
        {
            repository.Insert(region);
        }

        public void Update(Region region)
        {
            repository.Update(region);
        }
    }
}
