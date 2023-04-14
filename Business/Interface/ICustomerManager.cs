using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business.Interface
{
    public interface ICustomerManager
    {
        public List<Customer> GetCustomers();
        public bool UpdateCustomer(Customer customer);
        public bool DeleteCustomer(Guid id);
    }
}
