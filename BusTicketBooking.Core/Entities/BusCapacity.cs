using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusTicketBooking.Core.Entities
{
    public class BusCapacity
    {
        [Key]
        public int SeatId { get; set; }
        public string SeatName { get; set; }
        public bool BookedStatus { get; set; }
        public bool LockedStatus { get; set; }

        public ICollection<BookingStatus> BookingStatus { get; set; }
    }
}
