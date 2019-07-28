using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSitesi.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Giris()
        {
            return View();
        }

        public ActionResult Kayit()
        {
            return View();
        }
    }
}