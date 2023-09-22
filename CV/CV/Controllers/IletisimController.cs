using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.Entity;
using CV.Repositories;
namespace CV.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<Iletisim> repo = new GenericRepository<Iletisim>(); 
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}