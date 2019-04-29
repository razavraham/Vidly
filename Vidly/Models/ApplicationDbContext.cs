﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{


        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }


        public ApplicationDbContext()
                : base("DefaultConnection")
            {

            }

            public static ApplicationDbContext Save()
            {
                return new ApplicationDbContext();
            }
        }


    
}