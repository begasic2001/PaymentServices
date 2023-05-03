using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Payment.Application.Models;

namespace Payment.Host.Pages
{
    public class PaymentModel : PageModel
    {
        public double Amount { get; set; }
        public string Name { get; set; }
        public string OrderDescription { get; set; }
        public string OrderType { get; set; }
        public void OnGet()
        {
        }
        public void OnPostSubmit(PaymentInformationModel payment)
        {
            this.Amount = payment.Amount;
            this.Name = payment.Name;
            this.OrderDescription = payment.OrderDescription;
            this.OrderType =payment.OrderType;
        }
    }
}
