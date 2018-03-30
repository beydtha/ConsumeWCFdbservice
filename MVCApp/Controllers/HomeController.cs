using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.MyServiceClient _Service = new ServiceReference1.MyServiceClient();  
        public ActionResult Index()
        {
            var uList = new List<User>();
            var udList = _Service.GetAllUser();

            foreach(var item in udList)
            {
                var ur = new User();
                ur.Name = item.Name;
                ur.Email = item.email;
            //    ur.DeptID = item.deptid;

                uList.Add(ur);

            }
            return View(uList);
        }

        //public ActionResult Add()
        //{
        //    return View; 
        //}


        [HttpPost]
        public ActionResult Add(User u)
        {
            var ur = new User();
            ur.Name = u.Name;
            ur.Email = u.Email;
            ur.DeptID = u.DeptID;
            _Service.AddUser(ur.Name, ur.Email, ur.DeptID);

            return RedirectToAction("Index", "Home"); 
            
        }

        public ActionResult Delete(int id)
        {
            int retVal = _Service.DeleteUserById(id);
            if(retVal > 0)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            var usr = _Service.GetUserdetailbyId(id);

            var u = new User();
            u.Name = usr.Name;
            u.Email = usr.email;
            return View(u);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            var ur = new User();
            ur.Email = user.Email;
            ur.Name = user.Name;
            ur.Id = user.Id;
            int RetVal = 0;  //_Service.UpdateUser(ur.Id, ur.Name, ur.Email);

            if (RetVal > 0)
                return RedirectToAction("Index", "Home");

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}