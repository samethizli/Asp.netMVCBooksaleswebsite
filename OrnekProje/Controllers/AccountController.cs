using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using KitapHayalim.Entity;
using KitapHayalim.Identity;
using KitapHayalim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitapHayalim.Controllers
{
    public class AccountController : Controller
    {
        DataContext db = new DataContext();
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);
            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);
            
        }
       
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [Authorize]
        public ActionResult Index()
        {
            var username = User.Identity.Name;
            var orders = db.Orders.Where(i => i.UserName == username).Select(i => new UserOrderModel {

            Id=i.Id,
            OrderNumber=i.OrderNumber,
            OrderDate=i.OrderDate,
            OrderState=i.OrderState,
            Total=i.Total
            }).OrderByDescending(i=>i.OrderDate).ToList();

            return View(orders);
        }
        [Authorize]
        public ActionResult Profil()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userr = UserManager.FindById(User.Identity.GetUserId());

                if (userr != null)
                {

                    var user = new UserProfile()
                    {
                        Ad = userr.Name,
                        Soyad = userr.Surname,
                        Kullanıcıadı = userr.UserName,
                        Eposta = userr.Email,
                    };
                    return View("Profil", user);
                }
                else
                {
                    return View("Profil");
                }
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }

        }
        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id).Select(i => new OrderDetailsModel()
            {
                OrderId=i.Id,
                OrderNumber=i.OrderNumber,
                Total=i.Total,
                OrderDate=i.OrderDate,
                OrderState=i.OrderState,
                AdresBasligi=i.AdresBasligi,
                Adres=i.Adres,
                Sehir=i.Sehir,
                Semt=i.Semt,
                Mahalle=i.Mahalle,
                PostaKodu=i.PostaKodu,
                OrderLines=i.OrderLines.Select(x=> new OrderLineModel()
                {
                    ProductId=x.ProductId,
                    Image=x.Product.Image,
                    ProductName=x.Product.Name,
                    Quantity=x.Quantity,
                    Price=x.Price
                }).ToList()
            }).FirstOrDefault();
            return View(entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                

                if (model.Password.Length < 8)
                {
                    ModelState.AddModelError("Password", "Şifre 8 ila 16 karakter arasında olmalıdır!");
                }

                if(model.Password.Length > 16)
                {
                    ModelState.AddModelError("Password", "Şifre 8 ila 16 karakter arasında olmalıdır!");
                }


                    var user = new ApplicationUser();
                    user.Name = model.Name;
                    user.Surname = model.Surname;
                    user.Email = model.Email;
                    user.UserName = model.Username;
                    var result = UserManager.Create(user, model.Password);

                    if (result.Succeeded)
                    {
                        if (RoleManager.RoleExists("user"))
                        {
                            UserManager.AddToRole(user.Id, "user");
                        }
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        ModelState.AddModelError("RegisterUserError", "Kullanıcı oluşturma hatası..");
                    }
                
                
            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = UserManager.Find(model.Username, model.Password);
                if (user!=null)
                {
                    
                    var autManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;
                    autManager.SignIn(authProperties, identityclaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");

                   
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya parola hatalı...");
                }
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            var autManager = HttpContext.GetOwinContext().Authentication;
            autManager.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}