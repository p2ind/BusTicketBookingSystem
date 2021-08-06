using BusTicketBooking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketBooking.Infrastructure.Data
{
    public class TicketBookingContext : DbContext   
    {
        //public TicketBookingContext(DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<BusCapacity> BusCapacities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(@"data source=(local)\SQLExpress;Initial Catalog=BusBookingSystem;Integrated Security=True;");
            }
            base.OnConfiguring(optionBuilder);
        }
    }
}
