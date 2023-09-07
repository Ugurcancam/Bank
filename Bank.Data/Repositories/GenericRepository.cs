using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank.Data.Abstract;
using Bank.Data.Concrete;

namespace Bank.Data.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Create(T value)
        {
            using var context = new BankContext();
            context.Set<T>().Add(value);
            context.SaveChanges();
        }

        public void Delete(T value)
        {
            using var context = new BankContext();
            context.Set<T>().Remove(value);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new BankContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new BankContext();
            return context.Set<T>().Find(id);
        }

        public void Update(T value)
        {
            using var context = new BankContext();
            context.Set<T>().Update(value);
            context.SaveChanges();
        }
    }
}