using System;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Service.PaymentService
{
    public class PaymentService : Ipayment
    {
        private readonly AppDbContext _appDbContext;
        public PaymentService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ServiceResponse<List<PaymentMethod>>> CreatePayment(PaymentMethod newPayment)
        {
          ServiceResponse<List<PaymentMethod>> serviceResponse = new ServiceResponse<List<PaymentMethod>>();
        
       try
            {
                if(newPayment == null)
                {
                    serviceResponse.Data = null;
                    serviceResponse.message = "Informar dados!";
                    serviceResponse.success = false;
                    return serviceResponse;
                }


                _appDbContext.Add(newPayment);
                await _appDbContext.SaveChangesAsync();
            
            
            } catch (Exception ex)
                {
                serviceResponse.message = ex.Message;
                serviceResponse.success = false;
                }
        return serviceResponse;
        }

      
    }
}
