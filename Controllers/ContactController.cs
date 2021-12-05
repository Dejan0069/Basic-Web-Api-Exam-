using Microsoft.AspNetCore.Mvc;

namespace WebApiCRUD.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
