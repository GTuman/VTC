using Microsoft.AspNetCore.Mvc;

namespace VTC.Web.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
