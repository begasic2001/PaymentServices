
using Microsoft.AspNetCore.Mvc;
using Payment.Application.Interfaces;
using Payment.Application.Models;


namespace Payment.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly IVnPayService _vnPayService;

        public PaymentController(IVnPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }
        [HttpPost("CreatePaymentUrl")]
        public IActionResult CreatePaymentUrl(PaymentInformationModel model)
        {
            //PaymentInformationModel model
            var url = _vnPayService.CreatePaymentUrl(model,HttpContext);
            //return Ok(model);
            return Redirect(url);
        }
        [HttpGet("PaymentCallback")]
        public IActionResult PaymentCallback()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);

            return Json(response);
        }
    }
}
