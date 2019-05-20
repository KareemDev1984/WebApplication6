using KarimLamrini_EntityFramework.CustomErrorHandlers;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomErrorHandlerAttribute()); /// om altijd en overal toe te passen zonder attribuut
        }
    }
}
