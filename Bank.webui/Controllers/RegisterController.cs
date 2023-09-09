using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bank.Dto.AppUserDtos;
using Bank.Entity;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;

namespace Bank.webui.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid)
            {
                Random confirmcode = new Random();
                int code = confirmcode.Next(100000, 1000000);
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    NameSurname = appUserRegisterDto.NameSurname,
                    Email = appUserRegisterDto.Email,
                    ConfirmCode = code
                };
                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
                if(result.Succeeded)
                {
                    //Gönderilcek mesajla ilgili bilgileri oluşturuyoruz.
                    MimeMessage confirmMessage = new MimeMessage();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("CanSoft Sistem Kayıt","ugggurcan29@gmail.com"); // Mesaj başlığı, gönderilcek mail
                    MailboxAddress mailboxAdressTo = new MailboxAddress("User",appUser.Email);

                    confirmMessage.From.Add(mailboxAddressFrom);
                    confirmMessage.To.Add(mailboxAdressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz" + " " + code;
                    confirmMessage.Body = bodyBuilder.ToMessageBody();

                    confirmMessage.Subject = "Sistem onay kodu";

                    SmtpClient client = new SmtpClient();
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("ugggurcan29@gmail.com","rftcqwvgxrcnvowu");
                    client.Send(confirmMessage);
                    client.Disconnect(true);

                    TempData["Mail"] = appUserRegisterDto.Email;
                    return RedirectToAction("Index", "ConfirmMail");

                }
            }
            return View();
        }
    }
}