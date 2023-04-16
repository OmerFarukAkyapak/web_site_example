using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteExample.Models.Entity
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Faruk;Integrated Security=true");
        }

        public DbSet<Products> ProductsTable { get; set; }
        public DbSet<ShoppingCard> ProductsCard { get; set; }

    }
}
