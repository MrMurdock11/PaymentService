using Microsoft.AspNetCore.Mvc;
using PaymentService.Services;

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPayService _payService;
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(IPayService payService, ILogger<PaymentController> logger)
        {
            _payService = payService;
            _logger = logger;
        }

        [Route("pay")]
        [HttpPost()]
        public string Pay()
        {
            return _payService.Pay();
        }
    }
}
