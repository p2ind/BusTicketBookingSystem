using BusTicketBooking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketBooking.Infrastructure.Data
{
    public class TicketBookingContext : DbContext   
    {
        public TicketBookingContext(DbContextOptions<TicketBookingContext> options) : base(options)
        {
        }

        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<BusCapacity> BusCapacities { get; set; }
    }
}
