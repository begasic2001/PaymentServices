using Microsoft.AspNetCore.Http;
using Payment.Application.Models;


namespace Payment.Application.Interfaces
{
    public interface IVnPayService
    {
        //PaymentInformationModel model
        string CreatePaymentUrl(PaymentInformationModel model,HttpContext context);
        PaymentResponseModel PaymentExecute(IQueryCollection collections);
    }
}
