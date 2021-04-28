using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Habit.Models;

namespace MVC_Habit.Models
{
    public class HabitContext : DbContext
    {
        public DbSet<Habit> Habits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer(
            @"Data Source = S5D011\SQLEXPRESS; Initial Catalog = HabitCatalogen;" +
            " Integrated Security = True; Connect Timeout = 30; Encrypt = False;" +
            " TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"
        );
        }

        public DbSet<MVC_Habit.Models.ProgramSet> ProgramSet { get; set; }

        public DbSet<MVC_Habit.Models.Article> Article { get; set; }
    }
}
//Saving to Github
