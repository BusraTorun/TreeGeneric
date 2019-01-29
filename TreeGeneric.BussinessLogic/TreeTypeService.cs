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
    public class TreeTypeService:ITreeTypeService
    {
        private readonly IRepository<TreeType> repository;
        public TreeTypeService(IRepository<TreeType> repository)
        {
            this.repository = repository;
        }

        public void Insert(TreeType treeType)
        {
            repository.Insert(treeType);
        }

        public void Update(TreeType treeType)
        {
            repository.Update(treeType);
        }

        public void Delete(int id)
        {
            var treeTypeDelete = repository.Find(id);
            if (treeTypeDelete != null)
            {
                repository.Delete(treeTypeDelete);
            }
        }

        public TreeType Find(int id)
        {
            return repository.Find(id);
        }

        public TreeType Find(Expression<Func<TreeType, bool>> where)
        {
            return repository.Find(where);
        }

        public IEnumerable<TreeType> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<TreeType> GetAll(Expression<Func<TreeType, bool>> where)
        {
            return repository.GetAll(where).ToList();     
        }

       
    }
}
