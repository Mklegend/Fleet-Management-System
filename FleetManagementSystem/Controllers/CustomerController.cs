using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FleetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerManager customerManager;
        public CustomerController(ICustomerManager customerManager)
        {
            this.customerManager = customerManager;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return customerManager.GetCustomers();
        }

        [HttpPost]

        public bool Post([FromForm] Customer customer)
        {
            return customerManager.UpdateCustomer(customer);
        }

        [HttpDelete]

        public bool Delete([FromQuery] Guid id)
        {
            return customerManager.DeleteCustomer(id);
        }

    }


}
