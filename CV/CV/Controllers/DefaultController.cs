using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;

namespace CV.Controllers
{
	
    public class DefaultController : Controller
    {
        // GET: Default
        DBCvEntities db = new DBCvEntities();

        public ActionResult Index()
        {
            var degerler= db.Hakkimda.ToList();
            return View(degerler);

        }
		public PartialViewResult SosyalMedya()
		{
			var sosyalmedya = db.SosyalMedya.Where(x=>x.Durum==true).ToList();
			return PartialView(sosyalmedya);

		}
		public PartialViewResult Deneyim()
        {
            var deneyimler = db.Deneyimlerim.ToList();
            return PartialView(deneyimler);

        }
		public PartialViewResult Egitimlerim()
		{
			var egitimler = db.Egitimlerim.ToList();
			return PartialView(egitimler);

		}

		public PartialViewResult Yeteneklerim()
		{
			var yetenekler = db.Yeteneklerim.ToList();
			return PartialView(yetenekler);

		}


		public PartialViewResult Hobilerim()
		{
			var hobiler = db.Hobilerim.ToList();
			return PartialView(hobiler);

		}
		public PartialViewResult Sertifikalarim()
		{
			var sertifikalar = db.Sertifikalarim.ToList();
			return PartialView(sertifikalar);

		}
		[HttpGet] // sayfa yüklenirken çalışır
		public PartialViewResult Iletisim()
		{
			return PartialView();

		}
		[HttpPost]//butona baısınca çalışıcak

		public PartialViewResult Iletisim(Iletisim i)
		{
			i.Tarih= DateTime.Parse(DateTime.Now.ToShortDateString());

			db.Iletisim.Add(i);
			db.SaveChanges();
			return PartialView();

		}

	}
}