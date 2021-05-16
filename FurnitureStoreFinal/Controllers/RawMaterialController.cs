using FurnitureStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurnitureStoreFinal.Controllers
{
    public class RawMaterialController : Controller
    {
        // GET: Customer
        FurnitureStoreEntities objct = new FurnitureStoreEntities();

        public ActionResult RawDetails()
        {
            return View(objct.Rawmaterials.ToList());
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
        public ActionResult Create(Rawmaterial Raw)
        {
            if (!ModelState.IsValid)
                return View();
            objct.Rawmaterials.Add(Raw);
            objct.SaveChanges();
            return RedirectToAction("RawDetails");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var RawID = (from m in objct.Rawmaterials where m.id == id select m).First();
            return View(RawID);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Rawmaterial raw)
        {

            var orignalRecord = (from m in objct.Rawmaterials where m.id == raw.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            objct.Entry(orignalRecord).CurrentValues.SetValues(raw);

            objct.SaveChanges();
            return RedirectToAction("RawDetails");

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Rawmaterial raw)
        {
            var d = objct.Rawmaterials.Where(x => x.id == raw.id).FirstOrDefault();
            objct.Rawmaterials.Remove(d);
            objct.SaveChanges();
            return RedirectToAction("RawDetails");

        }
        // POST: RawMaterial/Delete/5
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
