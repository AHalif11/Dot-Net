using NGO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NGO.Controllers
{
    public class EmployeeController : Controller
    {
        NGOEntities db = new NGOEntities();

        [HttpGet]
        public ActionResult Registration() { return View(new Employee()); }
        // GET: Employee
        [HttpPost]
        public ActionResult Registration(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            TempData["msg"] = "Employee Registration Successfully";
            return RedirectToAction("List");
        }

        public ActionResult List() 
        {
            var data = db.Employees.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult CollectRequestList()
        {
            var data = db.CollectRequests.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult EditCollectionRequest(int id)
        {
            var data = db.CollectRequests.Find(id);
            ViewBag.emp = db.Employees.ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult EditCollectionRequest(CollectRequest cr)
        {
            var data = db.CollectRequests.Find(cr.RequestId);
            data.EmployeeId = cr.EmployeeId;
            data.Status = cr.Status;
            db.SaveChanges();
            TempData["msg"] = "Status updated Successfully";
            return RedirectToAction("CollectRequestList");
        }


    }
}