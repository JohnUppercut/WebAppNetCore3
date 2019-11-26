using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class KnifeContext : DbContext
    {
        public DbSet <Knife> Knifes { get; set; }
        public DbSet <Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }


        public KnifeContext(DbContextOptions<KnifeContext>options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
