using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitapHayalim.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Author { get; set; } // yazar
        public string Publisher { get; set; } // yayınevi
        public string Pages { get; set; }
    }
}