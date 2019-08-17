using NLog;
using NLog.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        [Filter.Filter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            //logger.SetProperty("action", null);
            //logger.SetProperty("Controller", null);
            //logger.SetProperty("CorrealactionId", null);
            //logger.SetProperty("UserId", null);
            //logger.Info(Environment.NewLine + DateTime.Now);
           

            return View();
        }
    }
}