using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppDamn.Models;
using AppDamnBLL;
using AppDamnModels;

namespace AppDamn.Controllers
{
    [Authorize(Roles ="Admin",Users ="")]
    public class UserAccountController : Controller
    {
        UserAccount _usrAccBAL; 
        // GET: UserAccount
        [HttpGet]
        public ActionResult RegisterUser()
        {
            _usrAccBAL = new UserAccount();
            AppDamnModels.UserAccViewModel modelObj = new UserAccViewModel();

            modelObj.ProfList = _usrAccBAL.GetProfessionInfo().ToList();
            
            return View(modelObj);
        }

        [HttpPost]
        public ActionResult RegisterUser(UserAccViewModel model)
        {
            ViewBag.Message = "Your contact page.";
            UserAccViewModel userModel = new UserAccViewModel();
            _usrAccBAL.CreateUserAccount(model);


            return View(model);
        }
        public bool ValidateUser()
        {
            ViewBag.Message = "Your application description page.";

            return true;
        }

    }
}