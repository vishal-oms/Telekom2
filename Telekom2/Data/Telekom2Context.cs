using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelekomBeckEnd;

namespace Telekom2.Data
{
    public class Telekom2Context : DbContext
    {
        public Telekom2Context (DbContextOptions<Telekom2Context> options)
            : base(options)
        {
            bool v = Database.EnsureCreated();
        }

        public DbSet<TelekomBeckEnd.Patient> Patient { get; set; }
        public DbSet<TelekomBeckEnd.State> State { get; set; }

        public DbSet<TelekomBeckEnd.City> City { get; set; }
    }
}
