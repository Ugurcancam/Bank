using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Entity.Concrete
{
    public class CustomerAccountTransictions
    {
        public int Id { get; set; }
        public string TransictionType { get; set; }
        public bool Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        

    }
}