using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Dto.AppUserDtos
{
    public class AppUserEditDto
    {
        public string NameSurname { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}