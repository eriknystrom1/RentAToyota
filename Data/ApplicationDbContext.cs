using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentAToyota2023.Models;

namespace RentAToyota2023.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RentAToyota2023.Models.Booking> Booking { get; set; }
        public DbSet<RentAToyota2023.Models.Car> Car { get; set; }
    }
}
