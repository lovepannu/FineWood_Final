using FurnitureStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurnitureStoreFinal.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        FurnitureStoreEntities objct = new FurnitureStoreEntities();

        public ActionResult ClientDetails()
        {
            return View(objct.Clients.ToList());
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
        public ActionResult Create(Client client)
        {
            if (!ModelState.IsValid)
                return View();
            objct.Clients.Add(client);
            objct.SaveChanges();
            return RedirectToAction("ClientDetails");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var clientID = (from m in objct.Clients where m.id == id select m).First();
            return View(clientID);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Client client)
        {

            var orignalRecord = (from m in objct.Clients where m.id == client.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            objct.Entry(orignalRecord).CurrentValues.SetValues(client);

            objct.SaveChanges();
            return RedirectToAction("ClientDetails");

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Client client)
        {
            var d = objct.Clients.Where(x => x.id == client.id).FirstOrDefault();
            objct.Clients.Remove(d);
            objct.SaveChanges();
            return RedirectToAction("ClientDetails");




        }

        // POST: Customer/Delete/5
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
