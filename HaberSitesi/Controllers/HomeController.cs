using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HaberSitesi.Models.DataBase;

namespace HaberSitesi.Controllers
{
    public class HomeController : Controller
    {
        HaberSitesiDBEntities HaberSitesiDB = new HaberSitesiDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            List<tbl_Haber> Haber = HaberSitesiDB.tbl_Haber.ToList();
            return View(Haber);
        }
    }
}