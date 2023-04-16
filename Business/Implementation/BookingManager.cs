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
    public class BookingManager : IBookingManager
    {
        private readonly DatabaseContext dbContext;
        public BookingManager(DatabaseContext databaseContext) {
            dbContext= databaseContext;
        }

        public List<Booking> GetBookings() {
            return dbContext.Booking.ToList();
        }
        public bool UpdateBooking(Booking booking) {

            bool BookingExists = dbContext.Booking.Any(b => b.BookingId == booking.BookingId);
            
            if (BookingExists)
            {
                dbContext.Booking.Update(booking);
            }
            else { 
                dbContext.Booking.Add(booking);
            }
            
            int result = dbContext.SaveChanges();

            if (result == 0) return false;

            return true;
        }
        public bool DeleteBooking(Guid id) { 
             bool BookingExists = dbContext.Booking.Any(b => b.BookingId == id);
            if (BookingExists) {
                dbContext.Booking.Remove(new Booking { BookingId = id });
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
