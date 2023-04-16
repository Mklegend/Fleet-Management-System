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
    public class PaymentManager : IPaymentManager
    {
        private readonly DatabaseContext dbContext;
        public PaymentManager(DatabaseContext databaseContext)
        {
            dbContext = databaseContext;
        }

        public List<Payment> GetPayments()
        {
            return dbContext.Payment.ToList();
        }
        public bool UpdatePayment(Payment payment)
        {

            bool PaymentExists = dbContext.Payment.Any(b => b.PaymentId == payment.PaymentId);

            if (PaymentExists)
            {
                dbContext.Payment.Update(payment);
            }
            else
            {
                dbContext.Payment.Add(payment);
            }

            int result = dbContext.SaveChanges();

            if (result == 0) return false;

            return true;
        }
        public bool DeletePayment(Guid id)
        {
            bool PaymentExists = dbContext.Payment.Any(b => b.PaymentId == id);
            if (PaymentExists)
            {
                dbContext.Payment.Remove(new Payment { PaymentId = id });
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
