using WebApplication1.Models;

namespace WebApplication1.Service.PaymentService
{
    public interface Ipayment
    {
     
        Task<ServiceResponse<List<PaymentMethod>>> CreatePayment(PaymentMethod newPayment);
    }
}
