using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookMVC.Entities;
using BookMVC.Dao;
namespace BookMVC.Controllers
{
     public class HomeController : Controller
     {
          public ActionResult Index()
          {
               return View();
          }

          public ActionResult About()
          {
               return View();
          }

          public ActionResult Contact()
          {
               return View();
          }

          public ActionResult TopNavBar()
          {
               ViewBag.Category = new CategoryDao().ListAll();
               ViewBag.BookCategory = new BookCatgoryDao().ListAll();
               return PartialView();
          }
     }
}