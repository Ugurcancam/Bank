using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Data.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Create (T value);
        void Delete (T value);
        void Update (T value);
        T GetById (int id);
        List<T> GetAll();
    }
}