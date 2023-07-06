using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class AccountService:IServicesBase<Account>
    {
        private readonly IServicesBase<Account> _servicesBase;

        public AccountService(IServicesBase<Account> servicesBase)
        {
            _servicesBase = servicesBase;
        }

        public AccountService()
        {
            IServicesBase<Account> servicesBase = new ServicesBase<Account>();

            _servicesBase = servicesBase;
        }

        public IQueryable<Account> GetAll()
        {
            return _servicesBase.GetAll();
        }

        public void Create(Account entity)
        {
            _servicesBase.Create(entity);
        }

        public bool Remove(Account entity)
        {
            return _servicesBase.Remove(entity);
        }

        public void Update(Account entity)
        {
            _servicesBase.Update(entity);
        }

    }
}
