using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitapHayalim.Entity
{
    public class Comment
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required]
        public String Username { get; set; }
        public int Id { get; set; }
        [Required]
        public String Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}