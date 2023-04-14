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
        public List<IPaymentManager> GetPayments();
        public bool UpdatePayment(IPaymentManager payment);

        // Add method for refund payment ! (Discuss)
        public bool DeletePayment(Guid id);
    }
}
