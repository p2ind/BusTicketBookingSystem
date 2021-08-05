using BusTicketBooking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketBooking.Core.Repositories
{
    public interface IBookingRepository : IRepository<BookingStatus>
    {
        Task<IEnumerable<BookingStatus>> GetAllBookingStatus(string mobileNumber);
    }
}
