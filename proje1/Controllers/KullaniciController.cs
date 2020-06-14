using proje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proje1.Controllers
{
    public class KullaniciController : Controller
    {
        ProjeDB db = new ProjeDB();
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }

        // GET: Kullanici/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kullanici/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kullanici/Create
        [HttpPost]
        public ActionResult Create(Kullanici model)
        {
            try
            {
                var varmi = db.Kullanicis.Where(i => i.KullaniciAdi == model.KullaniciAdi).SingleOrDefault();
                if (varmi != null)
                {
                    return View();
                }
                if (string.IsNullOrEmpty(model.Sifre)){
                    return View();
                }
                db.Kullanicis.Add(model);
                db.SaveChanges();
                Session["username"] = model.KullaniciAdi;
                return RedirectToAction("Index","Home");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Kullanici/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kullanici/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kullanici/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kullanici/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
