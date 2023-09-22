﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Repositories;
using CV.Models.Entity;

namespace CV.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<Hobilerim> repo = new GenericRepository<Hobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpPost]
		public ActionResult Index(Hobilerim p)
		{
            var t = repo.Find(x=>x.ID == 1);
            t.Aciklama1=p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
		}



	}
}