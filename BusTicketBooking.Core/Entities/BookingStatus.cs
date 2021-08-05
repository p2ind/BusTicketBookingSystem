using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusTicketBooking.Core.Entities
{
    public class BookingStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string UserMobileNo { get; set; }
        public string Status { get; set; }
        public bool IsArrived { get; set; }

        public int SeatId { get; set; }
        public BusCapacity BusCapacity { get; set; }
    }
}
