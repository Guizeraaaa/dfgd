using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Service.PaymentService;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly Ipayment _paymentService;
        public PaymentMethodController(Ipayment paymentInterface )
        {
            _paymentService = paymentInterface;
        }  


        [HttpPost]

       public async Task<ActionResult<ServiceResponse<List<PaymentMethod>>>> CreatePayment(PaymentMethod newPayment)
        {
            return Ok(await _paymentService.CreatePayment(newPayment));
        }


    }
}
