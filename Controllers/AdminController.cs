using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SkillProfileWidget_CodeFirstEntity.Models.siniflar;

namespace SkillProfileWidget_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();
        // GET: Admin
        public ActionResult Index()
        {

            var degerler = context.Skills.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniYetenek(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            //parametre olarak gelen id'ye göre Tablodan ilgili değeri bulman lazım:
            var deger = context.Skills.Find(id);
            context.Skills.Remove(deger);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YetenekGetir (int id) {
            var deger = context.Skills.Find(id);
            return View("YetenekGetir", deger);

        }

        public ActionResult Guncelle(Skill parametre)
        {
            var yetenek = context.Skills.Find(parametre.id);
            yetenek.Aciklama = parametre.Aciklama;
            yetenek.Deger = parametre.Deger;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

     
    }
}