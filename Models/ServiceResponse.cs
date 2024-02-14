namespace WebApplication1.Models
{
    public class ServiceResponse<T>
    {
      public T? Data { get; set; }



        public string message { get; set; } = string.Empty;

        public bool success { get; set; } = true;


    }
}
