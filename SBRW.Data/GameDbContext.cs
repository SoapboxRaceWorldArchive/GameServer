﻿// This file is part of SBRW.Data by heyitsleo.
// 
// Created: 11/27/2019 @ 10:13 PM.

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SBRW.Data.Entities;

namespace SBRW.Data
{
    public class GameDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public DbSet<AppPersona> Personas { get; set; }

        public GameDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppPersona>()
                .HasIndex(p => p.Name)
                .IsUnique();
            builder.Entity<AppOwnedCar>().Property<int>("PersonaId");
            builder.Entity<AppOwnedCar>()
                .HasOne(o => o.Persona)
                .WithMany(p => p.OwnedCars)
                .HasForeignKey("PersonaId");
            builder.Entity<AppOwnedCar>()
                .HasOne(o => o.CustomCar)
                .WithOne(c => c.OwnedCar)
                .HasForeignKey<AppCustomCar>(c => c.OwnedCarId);
        }
    }
}