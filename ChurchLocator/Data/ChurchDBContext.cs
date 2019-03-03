using System;
using System.Collections.Generic;
using System.Linq;
using ChurchLocator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChurchLocator.Data
{
    public class ChurchDbContext : DbContext
    {
        public DbSet<Church> Churches { get; set; }
        public DbSet<Denomination> Denominations { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<User> Users { get; set; }
       

        public ChurchDbContext(DbContextOptions<ChurchDbContext> options) : base(options)
        { }

       
    }
}
