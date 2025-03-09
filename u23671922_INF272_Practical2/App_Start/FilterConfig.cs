using System.Web;
using System.Web.Mvc;

namespace u23671922_INF272_Practical2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
