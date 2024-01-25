using KitapHayalim.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitapHayalim.Models
{
    public class State
    {
        DataContext db = new DataContext();
        public StateModelStyle GetModelState()
        {
            StateModelStyle models = new StateModelStyle();
            models.BeklenenSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Bekleniyor).ToList().Count();
            models.KargolanSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Kargolandı).ToList().Count();
            models.TamamlananSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Tamamlandı).ToList().Count();
            models.PaketlenenSiparisSayisi = db.Orders.Where(i => i.OrderState == EnumOrderState.Paketlendi).ToList().Count();
            models.UrunSayisi = db.Products.Count();
            models.SiparisSayisi = db.Orders.Count();
            models.UyeSayisi = db.Database.SqlQuery<int>("SELECT COUNT(*) FROM AspNetUsers").SingleOrDefault();
            models.KategoriSayisi = db.Categories.Count();

            return models;
        }
    }
    public class StateModelStyle
    {
        public int UrunSayisi { get; set; }
        public int SiparisSayisi { get; set; }

        public int UyeSayisi { get; set; }
        public int BeklenenSiparisSayisi { get; set; }
        public int KargolanSiparisSayisi { get; set; }
        public int TamamlananSiparisSayisi { get; set; }
        public int PaketlenenSiparisSayisi { get; set; }

        public int KategoriSayisi { get; set; }

    }

}