using KitapHayalim.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitapHayalim.Controllers
{
    public class UserEditViewModel
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; internal set; }
    }
}