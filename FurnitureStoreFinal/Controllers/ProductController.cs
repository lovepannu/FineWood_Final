using FurnitureStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurnitureStoreFinal.Controllers
{
    public class ProductController : Controller
    {
        // GET: Customer
        FurnitureStoreEntities objct = new FurnitureStoreEntities();

        public ActionResult ProductDetails()
        {
            return View(objct.Products.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return View();
            objct.Products.Add(product);
            objct.SaveChanges();
            return RedirectToAction("ProductDetails");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var productID = (from m in objct.Products where m.id == id select m).First();
            return View(productID);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {

            var orignalRecord = (from m in objct.Products where m.id == product.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            objct.Entry(orignalRecord).CurrentValues.SetValues(product);

            objct.SaveChanges();
            return RedirectToAction("ProductDetails");

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Product product)
        {
            var d = objct.Products.Where(x => x.id == product.id).FirstOrDefault();
            objct.Products.Remove(d);
            objct.SaveChanges();
            return RedirectToAction("ProductDetails");




        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
