using Business.Interface;
using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementation
{
    public class CustomerManager : ICustomerManager
    {
        private readonly DatabaseContext dbContext;
        public CustomerManager(DatabaseContext databaseContext)
        {
            dbContext = databaseContext;
        }

        public List<Customer> GetCustomers()
        {
            return dbContext.Customer.ToList();
        }
        public bool UpdateCustomer(Customer customer)
        {

            bool CustomerExists = dbContext.Customer.Any(b => b.CustomerId == customer.CustomerId);

            if (CustomerExists)
            {
                dbContext.Customer.Update(customer);
            }
            else
            {
                dbContext.Customer.Add(customer);
            }

            int result = dbContext.SaveChanges();

            if (result == 0) return false;

            return true;
        }
        public bool DeleteCustomer(Guid id)
        {
            bool CustomerExists = dbContext.Customer.Any(b => b.CustomerId == id);
            if (CustomerExists)
            {
                dbContext.Customer.Remove(new Customer { CustomerId = id });
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
