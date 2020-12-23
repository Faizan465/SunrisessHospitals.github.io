using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sunrisehospital.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace sunrisehospital.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       
        public DbSet<BookAppointment> BookAppointments { get; set; }

        public DbSet<Enquir> Enquirs { get; set; }














        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           




        }







    }
}
