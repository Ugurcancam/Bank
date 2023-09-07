using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank.Entity;
using Bank.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bank.Data.Concrete
{
    public class BankContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=U¦URCAN; initial catalog=BankDb; integrated security = true; TrustServerCertificate =true");
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountTransictions> CustomerAccountTransictionses { get; set; }
    }
}