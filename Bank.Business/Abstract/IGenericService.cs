using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Create(T value);
        void Update(T value);
        void Delete(T value);
        T GetById(int id);
        List<T> GetAll();
    }
}