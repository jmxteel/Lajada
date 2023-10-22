using Lajada.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lajada.Domain.Context
{
    public class LajadaDbContext : DbContext
    {
        public DbSet<Login> Login { get; set; } = null!;

        public DbSet<Personal_Information> Personal_Information { get; set; } = null!;

        public LajadaDbContext(DbContextOptions<LajadaDbContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personal_Information>().HasData(
                new Personal_Information()
                {
                    Id = 1,
                    Title = "Mr.",
                    FirstName = "John",
                    MiddleName = "Admin",
                    Surname = "Doe",
                    DateOfBirth = DateTime.Parse("2000-08-17 09:22:11.000"),
                    Age = 23,
                    Gender = "Male",
                    Address = "Madaue City"
                }
            );

            modelBuilder.Entity<Login>().HasData(
                new Login()
                {
                    Id = 1,
                    Personal_Information_Id = 1,
                    UserName = "ADMIN",
                    Password = "aB1?abc"
                }
            );

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}

    }

}
