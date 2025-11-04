using SecondLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondLab.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Project()
        {
            ViewBag.Message = "Here are my Projects";

            Project[] projects = new Project[3];
            projects[0] = new Project();
            projects[1] = new Project();
            projects[2] = new Project();

            projects[0].Title = "Netflix Clone";
            projects[0].CourseName = "JAVA";
            projects[0].Description = "Loading...";
            
            projects[1].Title = "Student Abroad Application Service System";
            projects[1].CourseName = "C#";
            projects[1].Description = "Help Student to find courses and universities";
            
            projects[2].Title = "AgriConnect";
            projects[2].CourseName = "Web technologies";
            projects[2].Description = "A Platform that Connects Farmers to Customers";



            return View(projects);
        }
        public ActionResult Result()
        {
            ViewData["Message"] = "Here are my Results";
            Result[] results = new Result[3];
            results[0] = new Result();
            results[1] = new Result();
            results[2] = new Result();

            results[0].ExamTitle = "SSC";
            results[0].ExamGrade = 5.00f;
            results[0].Institution = "Bangladesh Navy College Dhaka";

            results[1].ExamTitle = "HSC";
            results[1].ExamGrade = 5.00f;
            results[1].Institution = "Bangladesh Navy College Dhaka";

            results[2].ExamTitle = "BSc";
            results[2].ExamGrade = 1.1f;
            results[2].Institution = "AIUB";



            return View(results);
        }
        public ActionResult Contact()
        {
            ViewBag.Email = "alif@example.com";
            ViewBag.Contact = "01112121212";
            ViewBag.Address = "Uttara, Dhaka";
            return View();
        }
    }
}