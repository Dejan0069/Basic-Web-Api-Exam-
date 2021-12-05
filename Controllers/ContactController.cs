using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCRUD.Data;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext _db;

        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Contact> contactList = _db.Contact;
            //IEnumerable<Company> objList = _db.Company;
            return View(contactList);
        }
    }
}
