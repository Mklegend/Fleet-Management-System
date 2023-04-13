using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Cnic { get; set; }

        public string? LicenseNumber { get; set; }  

        // Add relationships here !
    }
}
