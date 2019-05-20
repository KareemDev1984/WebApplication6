using KarimLamrini_EntityFramework.CustomErrorHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        LogContext logContext = new LogContext();
        public ActionResult Index()
        {
            Logger logger = Logger.GetLogger();
            logger.WriteLogToDB("There is a terrible error","ApplicationName");
            return View();
        }

        [CustomErrorHandler]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var zero = 0;
            var result = 10 / zero;
            var errorList = logContext.Logs.ToList();

            return View(errorList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}