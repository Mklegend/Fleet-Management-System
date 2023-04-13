using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public Guid BookingId { get; set; }
        public int PaymentDue { get; set; }

        public DateTime PaymentDate { get; set; }

        public string? PaymentMethod { get; set; }

        // Add Relationships 
    }
}
