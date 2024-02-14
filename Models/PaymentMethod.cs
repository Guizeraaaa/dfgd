namespace WebApplication1.Models
{
    public class PaymentMethod
    {

        public int id { get; set; }

        public string paymentTitularName { get; set; }

        public string paymentCpf { get; set; }

        public string paymentNumberCard { get; set; }

        public int paymentCvv { get; set; }
        
        public string paymentExpiringDate { get; set;
        }
    }



    
}
