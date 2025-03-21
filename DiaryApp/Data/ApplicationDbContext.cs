﻿using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id=1,
                    Title="Went hiking",
                    Content="Went hiking with Joe",
                    Created=DateTime.Now
                },
                new DiaryEntry
                {
                    Id=2,
                    Title="Went Shopping",
                    Content="Went Shopping with Joe",
                    Created=DateTime.Now
                }
            );
        }
    }
}
