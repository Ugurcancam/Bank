using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank.Entity.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Bank.Entity
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }

    }
}