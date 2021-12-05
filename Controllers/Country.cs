using Microsoft.AspNetCore.Mvc;

namespace WebApiCRUD.Controllers
{
    public class Country : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
