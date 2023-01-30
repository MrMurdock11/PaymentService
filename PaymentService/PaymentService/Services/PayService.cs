namespace PaymentService.Services
{
    public interface IPayService
    {
        string Pay();
    }

    public class PayService : IPayService
    {
        public string Pay()
        {
            return "You paid for your item.";
        }
    }
}
