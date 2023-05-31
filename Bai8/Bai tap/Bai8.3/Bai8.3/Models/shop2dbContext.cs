using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Bai8._3.Models
{
    public class shop2dbContext : DbContext
    {
        public shop2dbContext() : base ("shop2dbContext") { }

        public DbSet<account> accounts { get; set; }
    }
}