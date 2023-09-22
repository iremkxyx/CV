﻿using CV.Models.Entity;
using CV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        DBCvEntities db = new DBCvEntities();
		GenericRepository<Hakkimda> repo = new GenericRepository<Hakkimda>();
		[HttpGet]
		public ActionResult Index()
		{
			var hakkimda = repo.List();
			return View(hakkimda);
		}
		[HttpPost]
		public ActionResult Index(Hakkimda p)
		{
			var t = repo.Find(x => x.ID == 1);
			t.Ad = p.Ad;
			t.Soyad = p.Soyad;
			t.Adres = p.Adres;
			t.Mail = p.Mail;
			t.Telefon = p.Telefon;
			t.Aciklama = p.Aciklama;
			t.Resim = p.Resim;
			repo.TUpdate(t);
			return RedirectToAction("Index");
		}


	}
}