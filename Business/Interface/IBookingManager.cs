using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Business.Interface
{
    public interface IBookingManager
    {
        public List<Booking> GetBookings();
        public bool UpdateBooking(Booking booking);
        public bool DeleteBooking(Guid id);
    }
}
