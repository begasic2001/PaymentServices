using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Application.Models
{
    public class PaymentInformationModel
    {
        [BindProperty]
        public string OrderType { get; set; }
        [BindProperty]
        public double Amount { get; set; }
        [BindProperty]
        public string OrderDescription { get; set; }
        [BindProperty]
        public string Name { get; set; }
    }
}
