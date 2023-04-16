using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IPaymentManager
    {
        public List<Payment> GetPayments();
        public bool UpdatePayment(Payment payment);

        // Add method for refund payment ! (Discuss)
        public bool DeletePayment(Guid id);
    }
}
