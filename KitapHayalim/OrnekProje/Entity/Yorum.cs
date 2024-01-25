using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitapHayalim.Entity
{
    public class Yorum
    {
        public int? Id { get; set; }
        public String UserName { get; set; }
        public String Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}