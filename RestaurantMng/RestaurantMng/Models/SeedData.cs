using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace RestaurantMng.Models
{
    public class SeedData : DropCreateDatabaseIfModelChanges<RestaurantDbContext>
    {
        protected override void Seed(RestaurantDbContext context)
        {
            //Category
           context.Categories.Add(new Category() {CategoryName = "Bnagladeshi"});
           context.Categories.Add(new Category() { CategoryName = "Chinese" });
           context.Categories.Add(new Category() { CategoryName = "Thai" });

            //ItemType
            context.ItemTypes.Add(new ItemType() {TypeName = "Vegetarian"});
            context.ItemTypes.Add(new ItemType() { TypeName = "Non-vegetarian" });


        }
    }
}