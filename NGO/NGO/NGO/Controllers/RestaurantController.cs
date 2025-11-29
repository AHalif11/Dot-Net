using NGO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO.Controllers
{
    public class RestaurantController : Controller
    {
        NGOEntities db = new NGOEntities();
        // GET: Restaurant
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Restaurant());
        }
        [HttpPost]
        public ActionResult Create(Restaurant r)
        {
            db.Restaurants.Add(r);
            db.SaveChanges();
            TempData["msg"] = "Restaurant Registration Successfully";
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            var data = db.Restaurants.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult CreateCollectRequest()
        {
            var data = db.Restaurants.ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult CreateCollectRequest(CollectRequest cr)
        {
            db.CollectRequests.Add(cr);
            db.SaveChanges();
            TempData["msg"] = "Collect Request Added Successfully";
            return RedirectToAction("List");
        }
    }
}