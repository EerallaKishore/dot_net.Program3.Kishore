using eClerx.Program3.Kishore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eClerx.Program3.Kishore.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public SuppliersController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Suppliers
        public ActionResult Index()
        {
            var suppliers = _dbContext.Suppliers.ToList();
            return View(suppliers);
        }
        //[HttpGet]        
        public ActionResult GetProducts(string City)
        {
            
            var suppliers = _dbContext.Suppliers.Where(p => p.City == City);
           
            return View("Index", suppliers);
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Suppliers.Add(supplier);
                _dbContext.SaveChanges();//To reflect the changes to database
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var supplier = _dbContext.Suppliers.FirstOrDefault(p => p.SupplierId == id);
            
            
            return View(supplier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                var productFromDb = _dbContext.Suppliers.FirstOrDefault(p => p.SupplierId == supplier.SupplierId);
                productFromDb.ContactName = supplier.ContactName;
                productFromDb.Address = supplier.Address;
                productFromDb.City = supplier.City;
                productFromDb.Pincode = supplier.Pincode;
                productFromDb.MobileNo = supplier.MobileNo;
                productFromDb.EmailId = supplier.EmailId;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(supplier);
        }
    }
}