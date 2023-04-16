using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FleetManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingManager bookingManager;
        public BookingController(IBookingManager bookingManager) {
            this.bookingManager = bookingManager;
        }

        [HttpGet]
        public List<Booking> Get()
        {
            return bookingManager.GetBookings();
        }

        [HttpPost]

        public bool Post([FromBody] Booking booking) {
            return bookingManager.UpdateBooking(booking);
        }

        [HttpDelete]

        public bool Delete([FromQuery] Guid id) {
            return bookingManager.DeleteBooking(id);
        }

    }


}
