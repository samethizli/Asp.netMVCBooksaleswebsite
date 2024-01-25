using KitapHayalim.Entity;
using KitapHayalim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitapHayalim.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Author = i.Author,
                Publisher = i.Publisher,
                Description = i.Description.Length > 25 ? i.Description.Substring(0, 20) + "..." : i.Description,
                Price = i.Price,
                Stock = i.Stock,
                Image = i.Image,
                CategoryId = i.CategoryId
            }
            ).ToList();
            return View(urun);
        }
        public PartialViewResult _Slider()
        {
            return PartialView(db.Products.Where(x => x.Slider && x.IsApproved).Take(3).ToList());
        }
        public PartialViewResult FeaturedProducList()
        {
            return PartialView(db.Products.Where(x => x.IsFeatured && x.IsApproved).Take(5).ToList());
        }
        public ActionResult ProductList(int id)
        {
            return View(db.Products.Where(i => i.CategoryId == id).ToList());
        }
        public ActionResult ProductDetails(int id)
        {
            ViewBag.Comments = db.Comments.Where(i => i.ProductId == id).ToList();
            return View(db.Products.Where(i => i.Id == id).FirstOrDefault());
            
        }
        public ActionResult Search(string q)
        {
            var p = db.Products.Where(i => i.IsApproved == true);
            if (!string.IsNullOrEmpty(q))
            {
                p = p.Where(i => i.Name.Contains(q) || i.Description.Contains(q));
            }
            return View(p.ToList());
        }
        public ActionResult Product()
        {
            var urun = db.Products.Where(i => i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Author = i.Author,
                Publisher = i.Publisher,
                Description = i.Description.Length > 25 ? i.Description.Substring(0, 20) + "..." : i.Description,
                Price = i.Price,
                Stock = i.Stock,
                Image = i.Image,
                CategoryId = i.CategoryId
            }
            ).ToList();
            return View(urun);
        }
        public ActionResult About()
        {
            return View();

        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}