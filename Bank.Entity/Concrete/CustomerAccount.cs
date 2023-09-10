using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Entity.Concrete
{
    public class CustomerAccount
    {
        [Key]
        public int Id {get; set;}
        public string CustomerAccountNumber{get;set;}
        public string CustomerAccountCurrency{get; set;}
        public string CustomerAccountBalance {get; set;}
        public string BankBranch{get; set;}
        public int AppUserId {get; set;}
        public AppUser AppUser {get; set;}
        public List<CustomerAccountTransictions> CustomerSender {get; set;}
        public List<CustomerAccountTransictions> CustomerReceiver {get; set;}

    }
}