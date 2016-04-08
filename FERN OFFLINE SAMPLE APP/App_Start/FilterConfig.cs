using System.Web;
using System.Web.Mvc;

namespace FERN_OFFLINE_SAMPLE_APP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}