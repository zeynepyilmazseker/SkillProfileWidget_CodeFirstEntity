using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SkillProfileWidget_CodeFirstEntity.Models.siniflar;

namespace SkillProfileWidget_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var degerler = c.Skills.ToList();
            return View(degerler);
        }
    }
}