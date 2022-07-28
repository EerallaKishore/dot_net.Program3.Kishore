using System.Web;
using System.Web.Mvc;

namespace eClerx.Program3.Kishore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
