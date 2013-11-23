using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Form()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            
            items.Add(new SelectListItem { Text = "Luxury", Value = "0", Selected = true });
            items.Add(new SelectListItem { Text = "Standard", Value = "1" });
            items.Add(new SelectListItem { Text = "Economic", Value = "2" });
            ViewBag.RoomType = items;
            
            return View();
        }


        
    }
}
