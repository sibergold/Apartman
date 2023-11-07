using Apartman.Models.veritabanı;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apartman.Controllers
{
    public class DurumController : Controller
    {
        // GET: Durum
        apartmanEntities db=new apartmanEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult otoparkdurumu()
        {

            var liste = db.park_yeri.ToList();
            return View(liste);
        }
        [HttpPost]
        public ActionResult otoparkdurumu(park_yeri P)
        {
            db.park_yeri.Add(P);
            db.SaveChanges();
            return RedirectToAction("otoparkdurumu");
        }
        public ActionResult SIL(int id)
        {
            db.park_yeri.Remove(db.park_yeri.Find(id));
            db.SaveChanges();
            return RedirectToAction("otoparkdurumu");

        }
    }
}