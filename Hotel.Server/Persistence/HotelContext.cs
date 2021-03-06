﻿using Hotel.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hotel.Server.Persistence
{
    public class HotelContext : DbContext
    {
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        public HotelContext(DbContextOptions options) : base(options) { }
        public HotelContext() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var room = builder.Entity<Room>();
            room.HasKey(e => e.Id);
            room.HasData(new
            {
                Id = 1,
                Beds = 1,
                DoubleBeds = 1,
                IsCondo = true,
                IsSuite = false,
                Smoking = false,
                Pets = false
            }, new
            {
                Id = 2,
                Beds = 1,
                DoubleBeds = 1,
                IsCondo = true,
                IsSuite = false,
                Smoking = true,
                Pets = false
            }, new
            {
                Id = 3,
                Beds = 2,
                DoubleBeds = 0,
                IsCondo = true,
                IsSuite = false,
                Smoking = true,
                Pets = false
            }, new
            {
                Id = 4,
                Beds = 2,
                DoubleBeds = 0,
                IsCondo = true,
                IsSuite = false,
                Smoking = true,
                Pets = true
            }, new
            {
                Id = 5,
                Beds = 1,
                DoubleBeds = 0,
                IsCondo = false,
                IsSuite = false,
                Smoking = true,
                Pets = false
            }, new
            {
                Id = 6,
                Beds = 2,
                DoubleBeds = 1,
                IsCondo = true,
                IsSuite = false,
                Smoking = true,
                Pets = false
            }, new
            {
                Id = 7,
                Beds = 2,
                DoubleBeds = 1,
                IsCondo = true,
                IsSuite = false,
                Smoking = true,
                Pets = false
            }, new
            {
                Id = 8,
                Beds = 2,
                DoubleBeds = 0,
                IsCondo = true,
                IsSuite = false,
                Smoking = false,
                Pets = false
            }, new
            {
                Id = 9,
                Beds = 2,
                DoubleBeds = 0,
                IsCondo = true,
                IsSuite = false,
                Smoking = false,
                Pets = false
            }, new
            {
                Id = 10,
                Beds = 1,
                DoubleBeds = 1,
                IsCondo = false,
                IsSuite = false,
                Smoking = false,
                Pets = true
            }, new
            {
                Id = 11,
                Beds = 1,
                DoubleBeds = 1,
                IsCondo = true,
                IsSuite = true,
                Smoking = false,
                Pets = true
            }, new
            {
                Id = 12,
                Beds = 2,
                DoubleBeds = 2,
                IsCondo = true,
                IsSuite = false,
                Smoking = false,
                Pets = true
            }, new
            {
                Id = 13,
                Beds = 2,
                DoubleBeds = 2,
                IsCondo = true,
                IsSuite = false,
                Smoking = true,
                Pets = false
            }, new
            {
                Id = 14,
                Beds = 2,
                DoubleBeds = 1,
                IsCondo = true,
                IsSuite = false,
                Smoking = true,
                Pets = false
            }, new
            {
                Id = 15,
                Beds = 2,
                DoubleBeds = 1,
                IsCondo = true,
                IsSuite = false,
                Smoking = false,
                Pets = true
            }, new
            {
                Id = 16,
                Beds = 2,
                DoubleBeds = 0,
                IsCondo = true,
                IsSuite = false,
                Smoking = false,
                Pets = true
            }, new
            {
                Id = 17,
                Beds = 2,
                DoubleBeds = 0,
                IsCondo = true,
                IsSuite = false,
                Smoking = false,
                Pets = false
            }, new
            {
                Id = 18,
                Beds = 2,
                DoubleBeds = 0,
                IsCondo = false,
                IsSuite = false,
                Smoking = true,
                Pets = false
            });

            var booking = builder.Entity<Booking>();
            booking.HasData(new
            {
                Id = 1,
                IsCanceled = false,
                BookingNumber = "foo",
                CheckInDate = DateTime.Parse("Dec 15, 1780"),
                CheckOutDate = DateTime.Parse("Dec 20, 1780"),
                FirstName = "Old",
                LastName = "Old guy name",
                Email = "mail@testsson.com",
                PhoneNumber = "+462971937492",
                Address = "Old Avenue 5",
                Guests = 1,
                Breakfast = true,
                SpaAccess = false,
                Created = DateTime.Now,
                RoomId = 1

            });
            booking.HasKey(e => e.Id);

            var review = builder.Entity<Review>();
            review.HasKey(e => e.Id);
            review.HasIndex(u => u.BookingNumber).IsUnique();
            review.HasData(new
            {
                Id = 1,
                Description = "The booking process was very simple and easy to navigate. Our family higly reccomends this hotel!",
                Grade = 5,
                Anonymous = true,
                FirstName = "",
                LastName = "",
                BookingNumber = "bar",
                Created = DateTime.Now
            }, new
            {
                Id = 2,
                Description = "The booking site was great",
                Grade = 4,
                Anonymous = true,
                FirstName = "",
                LastName = "",
                BookingNumber = "foo",
                Created = DateTime.Now
            }, new
            {
                Id = 3,
                Description = "The booking site was ok",
                Grade = 3,
                Anonymous = true,
                FirstName = "",
                LastName = "",
                BookingNumber = "klas",
                Created = DateTime.Now
            }, new
            {
                Id = 4,
                Description = "The booking site was really cool, great design!",
                Grade = 5,
                Anonymous = true,
                FirstName = "",
                LastName = "",
                BookingNumber = "klas2",
                Created = DateTime.Now
            }
            );


        }
    }
}
