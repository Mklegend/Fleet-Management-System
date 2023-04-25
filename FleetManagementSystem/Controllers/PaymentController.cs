using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FleetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentManager paymentManager;
        public PaymentController(IPaymentManager paymentManager)
        {
            this.paymentManager = paymentManager;
        }

        [HttpGet]
        public List<Payment> Get()
        {
            return paymentManager.GetPayments();
        }

        [HttpPost]

        public bool Post([FromForm] Payment payment)
        {
            return paymentManager.UpdatePayment(payment);
        }

        [HttpDelete]

        public bool Delete([FromQuery] Guid id)
        {
            return paymentManager.DeletePayment(id);
        }

    }


}
