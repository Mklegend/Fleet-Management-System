using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Booking
    {
        Guid BookingId { get; set; }
        Guid CustomerId { get; set; }
        Guid VehicleId { get; set; }

        DateTime BookingDate { get; set; }
        string? Driver { get; set; }

        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }

        int BookingFee { get; set; }

        // Add Objects for Creating Relationships
    }
}
