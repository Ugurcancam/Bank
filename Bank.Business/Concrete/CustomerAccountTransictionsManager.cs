using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank.Business.Abstract;
using Bank.Data.Abstract;
using Bank.Entity.Concrete;

namespace Bank.Business.Concrete
{
    public class CustomerAccountTransictionsManager : ICustomerAccountTransictionsService
    {
        private readonly ICustomerAccountTransictionsDal _customerAccountTransictionsDal;

        public CustomerAccountTransictionsManager(ICustomerAccountTransictionsDal customerAccountTransictionsDal)
        {
            _customerAccountTransictionsDal = customerAccountTransictionsDal;
        }

        public void Create(CustomerAccountTransictions value)
        {
            _customerAccountTransictionsDal.Create(value);
        }

        public void Delete(CustomerAccountTransictions value)
        {
            _customerAccountTransictionsDal.Delete(value);
        }

        public List<CustomerAccountTransictions> GetAll()
        {
            return _customerAccountTransictionsDal.GetAll();
        }

        public CustomerAccountTransictions GetById(int id)
        {
            return _customerAccountTransictionsDal.GetById(id);
        }

        public void Update(CustomerAccountTransictions value)
        {
            _customerAccountTransictionsDal.Update(value);
        }
    }
}