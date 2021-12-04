using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCRUD.Data;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CompanyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Company> objList = _db.Company;
            //IEnumerable<Company> objList = _db.Company;
            return View(objList);
        }

       //Get Create
        public IActionResult Create()
        {
            
            return View();
        }

        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Company obj)
        {
            if (ModelState.IsValid)
            {
                _db.Company.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //Get Edit
        public IActionResult Edit(int id)
        {
            if ( id == 0)
            {
                return NotFound();
            }
            var obj = _db.Company.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

            
        }

        //Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Company obj)
        {
            if (ModelState.IsValid)
            {
                _db.Company.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //Get Delete
        public IActionResult Delete(int id)
        {
            if ( id == 0)
            {
                return NotFound();
            }
            var obj = _db.Company.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);


        }

        //Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            var obj = _db.Company.Find(id);

                _db.Company.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
           
            

        }


    }
}
