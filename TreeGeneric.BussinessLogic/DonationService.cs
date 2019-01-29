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
    public class DonationService:IDonationService
    {
        private readonly IRepository<Donation> repository;
        public DonationService(IRepository<Donation> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            var donationDelete = repository.Find(id);
            if (donationDelete != null)
            {
                repository.Delete(donationDelete);
            }
        }

        public Donation Find(int id)
        {
            return repository.Find(id);
        }

        public Donation Find(Expression<Func<Donation, bool>> where)
        {
            return repository.Find(where);
        }

        public IEnumerable<Donation> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<Donation> GetAll(Expression<Func<Donation, bool>> where)
        {
            return repository.GetAll(where).ToList();
        }

        public void Insert(Donation donation)
        {
            repository.Insert(donation);
        }

        public void Update(Donation donation)
        {
            repository.Update(donation);
        }
    }
}
