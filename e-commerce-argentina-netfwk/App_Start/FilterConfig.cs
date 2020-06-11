using System.Web;
using System.Web.Mvc;

namespace e_commerce_argentina_netfwk
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
