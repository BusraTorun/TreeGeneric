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
    public class PlantingService : IPlantingService
    {
        private readonly IRepository<Planting> repository;
        public PlantingService(IRepository<Planting> repository)
        {
            this.repository = repository;
        }
        public void Delete(int id)
        {
            var planting = repository.Find(id);
            if (planting != null)
            {
                repository.Delete(planting);
            }
        }

        public Planting Find(int id)
        {
            return repository.Find(id);
        }

        public Planting Find(Expression<Func<Planting, bool>> where)
        {
            return repository.Find(where); 
        }

        public IEnumerable<Planting> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<Planting> GetAll(Expression<Func<Planting, bool>> where)
        {
            return repository.GetAll(where);
        }

        public void Insert(Planting planting)
        {
            repository.Insert(planting);
        }

        public void Update(Planting planting)
        {
            repository.Update(planting);
        }
    }
}
