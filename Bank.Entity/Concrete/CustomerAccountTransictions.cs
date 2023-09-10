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
        public string Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public CustomerAccount SenderCustomer { get; set; }
        public CustomerAccount ReceiverCustomer { get; set; }

    }
}