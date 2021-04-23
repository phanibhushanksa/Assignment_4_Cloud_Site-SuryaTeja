using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_4_Cloud_Site.Models;

namespace Assignment_4_Cloud_Site.DataAccess
{
    public class Assignment_4_Cloud_SiteDBContext : DbContext
    {
        public Assignment_4_Cloud_SiteDBContext(DbContextOptions<Assignment_4_Cloud_SiteDBContext> options) : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<Calorie> Calories { get; set; }
    }
}