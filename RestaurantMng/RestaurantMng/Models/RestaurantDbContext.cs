using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantMng.Models
{
    public class RestaurantDbContext:DbContext
    {
        public DbSet<Category> Categories { set; get; }
        public DbSet<ItemType> ItemTypes { set; get; }
        public DbSet<Menu> Menus { set; get; } 
    }
}