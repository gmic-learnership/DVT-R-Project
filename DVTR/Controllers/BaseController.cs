using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVTR.Controllers
{
    public class BaseController : Controller
    {

        public int GetSessionPersonID()
        {
            if (Session["personId"] != null)
            {
                return (int)Session["personId"];
            }
            RedirectToAction("login", "Home");

            return -1;

        }
        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
    }
}