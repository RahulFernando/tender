using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ceb_tender_app.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ceb_tender_app.Models
{
    public class applicationContext : IdentityDbContext<applicationUser>
    {
        // set tables
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

        public applicationContext(DbContextOptions<applicationContext> options)
            : base(options)
        {
        }
    }
}
