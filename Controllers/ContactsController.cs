using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
