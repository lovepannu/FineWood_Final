using FurnitureStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurnitureStoreFinal.Controllers
{
    public class HomeController : Controller
    {
        FurnitureStoreEntities objct = new FurnitureStoreEntities();


        public ActionResult QueryDetails()
        {
            return View(objct.Queries.ToList());
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
        [HttpPost]
        public ActionResult sendMessage(Message contct)
        {
            //Pass the data to store the record into the table 


            contct.sendMessage("insert into Query values('" + contct.SName + "','" + contct.Sphone + "','" + contct.Smessage + "')");

            return View("Confirmation");




        }

        public ActionResult Confirmation()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




    }
}