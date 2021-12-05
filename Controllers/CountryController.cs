using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCRUD.Data;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    public class CountryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CountryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Country> countryList = _db.Country;
            
            return View(countryList);
        }

        public IActionResult Create()
        {

            return View();
        }

        public IActionResult CreateCountry(Country obj)
        {
            if (ModelState.IsValid)
            {
                _db.Country.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var obj = _db.Country.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        //Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Country obj)
        {
            if (ModelState.IsValid)
            {
                _db.Country.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            var obj = _db.Country.Find(id);

            _db.Country.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }




    }
}
