using KarimLamrini_EntityFramework.CustomErrorHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    [CustomErrorHandler]
    public class LogController : Controller
    {
        LogContext logContext = new LogContext();
        // GET: Log
        public ActionResult Index()
        {

            int a, b, c = 0;
            a = 10;
            b = a / c;
            var errorList = logContext.Logs.ToList();

            return View(errorList);
        }
    }
}