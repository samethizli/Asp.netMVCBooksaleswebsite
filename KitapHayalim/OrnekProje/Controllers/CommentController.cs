using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KitapHayalim.Entity;

namespace KitapHayalim.Controllers
{
    [Authorize(Roles = "admin")]
    public class CommentController : Controller
    {
        private DataContext db = new DataContext();

        public ActionResult Index(int? id)
        {

            if (id != null)
            {
                var comments = db.Comments.Where(i => i.ProductId == id);
                return View(comments.ToList());
            }
            else
            {
                var comments = db.Comments.Include(c => c.Product);
                return View(comments.ToList());
            }


        }
        [AllowAnonymous]
        public ActionResult Create(int id)
        {
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name");
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Username,Description,ProductId")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return RedirectToAction("ProductDetails", "", new { id = comment.ProductId });
            }

            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", comment.ProductId);
            return View(comment);
        }



        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            db.Comments.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("Index"); // Başarılı silme işleminden sonra Index yöntemine yönlendirme yapılıyor
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}