using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SKILLS.Models.classes;
namespace SKILLS.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        public ActionResult Index()
        {
            CONTEXT c = new CONTEXT();
            var values = c.SKILLS.ToList();
            return View(values);
        }
    }
}