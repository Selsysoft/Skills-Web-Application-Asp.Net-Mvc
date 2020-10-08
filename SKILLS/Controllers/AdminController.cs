using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SKILLS.Models.classes;

namespace SKILLS.Controllers
{
    public class AdminController : Controller
    {
        CONTEXT c = new CONTEXT();
        // GET: Admin
        public ActionResult Index()
        {
            
            var values = c.SKILLS.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewSkill(SKILL s)
        {
            c.SKILLS.Add(s);
            c.SaveChanges();
            return View();
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = c.SKILLS.Find(id);
            c.SKILLS.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = c.SKILLS.Find(id);
            return View("UpdateSkill", value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(SKILL s)
        {
            var x = c.SKILLS.Find(s.ID);
            x.ACIKLAMA = s.ACIKLAMA;
            x.DEGER = s.DEGER;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}