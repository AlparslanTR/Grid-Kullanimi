using System.Web;
using System.Web.Mvc;

namespace Css_Grid_Kullanımı
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
