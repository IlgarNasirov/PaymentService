using Microsoft.AspNetCore.Mvc;

namespace PaymentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentServiceController : ControllerBase
    {
        private PaymentService? _paymentService;
        [HttpGet("GetBitcoinBalance")]
        public IActionResult GetBitcoinBalance()
        {
            _paymentService = new PaymentService(new BitcoinStrategy());
            _paymentService.CheckBalance();
            return Ok();
        }
        [HttpPost("IncreasePaypalBalance")]
        public IActionResult IncreasePaypalBalance([FromBody]double amount)
        {
            _paymentService=new PaymentService(new PaypalStrategy());
            _paymentService.IncreaseBalance(amount);
            return Ok();
        }
        [HttpPost("PayCreditCard")]
        public IActionResult PayCreditCard([FromBody] double amount)
        {
            _paymentService = new PaymentService(new CreditCardStrategy());
            _paymentService.Pay(amount);
            return Ok();
        }

    }
}
