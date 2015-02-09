using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantMng.Models
{
    public class Menu
    {
       
        public int MenuId { get; set; }

         [Required(ErrorMessage = "Nmae field must be required")]
        public string Name { get; set; }

         [Required(ErrorMessage = " Insert category name")]
        [Display(Name = "Category Id")]
        public int CategoryID { get; set; }
         public virtual Category Category { set; get; }
        public string Description { get; set; }

         [Required(ErrorMessage = "Price field must be required")]
        public double Price { get; set; }

         [Required(ErrorMessage = "Insert a type")]
        [Display(Name = "Type Name")]
        public int ItemTypeId { get; set; }
        public virtual ItemType ItemType { set; get; }

    }
}