using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank.Business.Abstract;
using Bank.Data.Abstract;
using Bank.Entity.Concrete;

namespace Bank.Business.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void Create(CustomerAccount value)
        {
            _customerAccountDal.Create(value);
        }

        public void Delete(CustomerAccount value)
        {
            _customerAccountDal?.Delete(value);
        }

        public List<CustomerAccount> GetAll()
        {
            return _customerAccountDal.GetAll();
        }

        public CustomerAccount GetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public void Update(CustomerAccount value)
        {
            _customerAccountDal.Update(value);
        }
    }
}