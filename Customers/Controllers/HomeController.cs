using Customers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CustomerForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CustomerForm(Customer customer)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(customer);
                return View("Thanks", customer);
            }
            else
            {
                return View();
            }

        }

        public ViewResult ListReturners()
        {
            return View(Repository.Responses.Where(r => r.WillBuyAgain == true));
        }
    }

}
