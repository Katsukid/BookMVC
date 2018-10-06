using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookMVC.Entities;
using BookMVC.Dao;
namespace BookMVC.Controllers
{
    public class UserController : Controller
    {
          BookMVCDbContext db;
          // GET: User
          public ActionResult Index()
          {
               return View();
          }
          public ActionResult LoginModal()
          {
               return PartialView();
          }
          
          public ActionResult Login()
          {
               return View();
          }
          [HttpPost]
          public ActionResult Login(User acc)
          {
               UserDao dao = new UserDao();
               bool check = dao.Login(acc.Email, acc.Password);
               if (check)
               {
                    Session["UserName"] = acc.Email;
                    return RedirectToAction("Index", "Home");
               }
               return RedirectToAction("Login","User");
          }
          public ActionResult Register()
          {
               return View();
          }
          [HttpPost]
          public ActionResult Register(User us)
          {
               db = new BookMVCDbContext();
               var log = new UserDao();
               {
                    if (ModelState.IsValid)
                    {
                         if (!log.ValidEmail(us.Email)){
                              setAlert("Email không hợp lệ hoặc không tồn tại!","Error");
                         }
                         else if (log.ExistedEmail(us.Email))
                         {
                              setAlert("Email đã được sử dụng bởi tài khoản khác!", "Error");
                         }
                         else
                         {
                              var res = log.AddUser(us);
                              if (res)
                              {
                                   setAlert("Đăng ký thành công!", "success");
                                   return Redirect("/");
                              }
                              else
                              {
                                   setAlert("Đăng ký không thành công! Quý khác vui lòng đăng ký lại", "error");
                                   return RedirectToAction("Register","User");
                              }
                         }
                    }
               }
               return this.Register();
          }
          // Canh bao nguoi dung
          public void setAlert(string message, string type)
          {
               TempData["AlertMessage"] = message;
               if (type == "success")
               {
                    TempData["AlertType"] = "alert-success";
               }
               else if (type == "error")
               {
                    TempData["AlertType"] = "alert-danger";
               }
          }
     }
}