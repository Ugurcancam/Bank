using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.webui.Models
{
    public class ConfirmMailViewModel
    {
        public string Mail { get; set; }
        public int ConfirmCode { get; set; }
    }
}