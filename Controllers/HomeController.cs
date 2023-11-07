using Apartman.Models.veritabanı;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apartman.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        apartmanEntities entities=new apartmanEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult kayitekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult kayitekle(kisi_bilgileri p)
        {
            entities.kisi_bilgileri.Add(p);
            entities.SaveChanges();
            return RedirectToAction("kayitlistele");
        }
        public ActionResult kayitlistele()
        {
            var liste=entities.kisi_bilgileri.ToList();
            return View(liste);
        }
        public ActionResult sil(int id)
        {
            entities.kisi_bilgileri.Remove(entities.kisi_bilgileri.Find(id));
            entities.SaveChanges();
            return RedirectToAction("kayitlistele");
        }
        public ActionResult KisiGetir(int id)
        {
            var getir = entities.kisi_bilgileri.Find(id);
            return View("KisiGetir",getir);
        }
        public ActionResult KisiyiGuncelle(kisi_bilgileri k)
        {
            var kisi = entities.kisi_bilgileri.Find(k.kisi_id);
            kisi.tc_kimlik = k.tc_kimlik;
            kisi.ad = k.ad;
            kisi.soyad = k.soyad;
            kisi.cep_telefonu = k.cep_telefonu;
            kisi.Adres = k.Adres;
            entities.SaveChanges();
            return RedirectToAction("kayitlistele");
        }
    }
}