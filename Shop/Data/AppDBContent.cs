
using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data {
    public class AppDBContent : DbContext {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { 
            
        }

        public DbSet<Car> Car { set; get; }

        public DbSet<Category> Category { set; get; }

        public DbSet<ShopCartItem> ShopCartItem { set; get; }


    }
}
