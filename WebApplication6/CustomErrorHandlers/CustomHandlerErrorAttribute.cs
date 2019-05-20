using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace KarimLamrini_EntityFramework.CustomErrorHandlers
{
    public class CustomErrorHandlerAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            string controllerName = "Your controller name is:" + filterContext.RouteData.Values["controller"].ToString();
            string actionName = "Your action name is:" + filterContext.RouteData.Values["action"].ToString();
            HandleErrorInfo model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

            var writeLogger = Logger.GetLogger();
            writeLogger.WriteLogToDB(filterContext.Exception.Message, "ErrorApp");

            ViewResult _viewResult = new ViewResult();
            _viewResult.ViewName = "MyErrorPage";  // custom ErrrorPage
            _viewResult.MasterName = this.Master;
            _viewResult.ViewData = new ViewDataDictionary<HandleErrorInfo>(model);
            _viewResult.TempData = filterContext.Controller.TempData;
            filterContext.Result = _viewResult;

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.StatusCode = 500;
            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;

        }

    }
}