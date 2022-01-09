using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;
namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        HobiRepository repo = new HobiRepository();
        // GET: Hobi
        [HttpGet]
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
          
        }  
        [HttpPost]
        public ActionResult Index(TblHobilerim p)
        {
            TblHobilerim t= repo.Find(x => x.ID == p.ID);
            t.Aciklama1 = p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            t.ID = p.ID;
            repo.TUpdate(t);
            return RedirectToAction("Index");

        }
    }
}