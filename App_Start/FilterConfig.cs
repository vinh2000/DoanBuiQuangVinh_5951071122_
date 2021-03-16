using System.Web;
using System.Web.Mvc;

namespace DoanBuiQuangVinh_5951071122
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
