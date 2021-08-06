using System.Web;
using System.Web.Mvc;

namespace Fruits_SA_Devloper_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
