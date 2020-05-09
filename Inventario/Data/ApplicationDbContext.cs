using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Inventario.Models;
using Microsoft.AspNetCore.Identity;

namespace Inventario.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().Ignore(e => e.FullName);
        }

       

      
        public DbSet<Inventario.Models.Item> Items { get; set; }
        public DbSet<Inventario.Models.ItemSize> ItemSizes { get; set; }
        public DbSet<Inventario.Models.ItemType> ItemTypes { get; set; }
        public DbSet<Inventario.Models.Company> Companies { get; set; }
        public DbSet<Inventario.Models.Stock> Stocks { get; set; }



    }
}
