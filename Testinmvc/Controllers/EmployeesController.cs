using Microsoft.AspNetCore.Mvc;

namespace Testinmvc.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
