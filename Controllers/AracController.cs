using Apartman.Models.veritabanı;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apartman.Controllers
{
    public class AracController : Controller
    {
        // GET: Arac
        apartmanEntities db=new apartmanEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AracGoster()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AracGoster(arac_bilgileri P)
        {
            db.arac_bilgileri.Add(P);
            db.SaveChanges();
            return RedirectToAction("AracCikis");
        }
        public ActionResult AracCikis()
        {
            var listee = db.arac_bilgileri.ToList();
            return View(listee);
        }
        public ActionResult SIL(int id)
        {
            db.arac_bilgileri.Remove(db.arac_bilgileri.Find(id));
            db.SaveChanges();
            return RedirectToAction("AracCikis");

        }
        public ActionResult AracGetir(int id)
        {
            var arac = db.arac_bilgileri.Find(id);
            return View("AracGetir", arac);
        }
        public ActionResult AracıGuncelle(arac_bilgileri P1)
        {
            var kisi = db.arac_bilgileri.Find(P1.arac_id);
            kisi.arac_plaka = P1.arac_plaka;
            kisi.arac_marka = P1.arac_marka;
            kisi.arac_renk = P1.arac_renk;
            kisi.kisi_id = P1.kisi_id;
            db.SaveChanges();
            return RedirectToAction("AracCikis");
        }
    }
}