using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace KitapHayalim.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("admin"))
            {
                var role = new IdentityRole { Name = "admin" };
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("user"))
            {
                var role = new IdentityRole { Name = "user" };
                roleManager.Create(role);
            }

            if (!context.Users.Any(i => i.UserName == "kekomalp"))
            {
                var user = new ApplicationUser { UserName = "kekomalp", Email = "keremalp@gmail.com", Name = "kerem", Surname = "alp" };
                var result = userManager.Create(user, "12345678");
                if (result.Succeeded)
                {
                    userManager.AddToRole(user.Id, "admin");
                    userManager.AddToRole(user.Id, "user");
                }
            }

            if (!context.Users.Any(i => i.UserName == "samethizli"))
            {
                var user = new ApplicationUser { UserName = "samethizli", Email = "samethizli@gmail.com", Name = "samet", Surname = "hizli" };
                var result = userManager.Create(user, "12345678");
                if (result.Succeeded)
                {
                    userManager.AddToRole(user.Id, "admin");
                    userManager.AddToRole(user.Id, "user");
                }
            }

            base.Seed(context);
        }
    }
}
