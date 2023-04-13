using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid VehicleId { get; set; }

        public DateTime BookingDate { get; set; }
        public string? Driver { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int BookingFee { get; set; }

        // Add Objects for Creating Relationships
    }
}
