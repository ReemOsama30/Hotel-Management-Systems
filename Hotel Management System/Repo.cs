using Microsoft.EntityFrameworkCore;
using 
    System;
using System.Collections.Generic;
using System.Text;

namespace HotelProject
{
    class Repo : DbContext
    {



        public DbSet<Booking> bookings { get; set; }
    }
}
