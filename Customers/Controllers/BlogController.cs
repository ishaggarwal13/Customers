using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
