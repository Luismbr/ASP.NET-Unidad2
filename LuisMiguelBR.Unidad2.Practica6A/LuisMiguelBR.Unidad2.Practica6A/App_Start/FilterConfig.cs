using System.Web;
using System.Web.Mvc;

namespace LuisMiguelBR.Unidad2.Practica6A
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
