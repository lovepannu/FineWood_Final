using FurnitureStoreFinal.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurnitureStoreFinal.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        public ActionResult AdminIndex()
        {
            return View();
        }

        // GET: Manage
        public ActionResult wrong()
        {
            return View();
        }
        
        // GET: Manage
        public ActionResult WorkingArea()
        {
            return View();
        }

        [HttpPost]
        public ActionResult validateLogin(AdminDB lgin)
        {
            //Pass the data to store the record into the table 

            DataTable tbl = new DataTable();

            tbl = lgin.chkkLogin("select * from AdminDetails where AdminName='"+lgin.Sname+"' and AdminPassword='"+lgin.Spassword+"'");

            if (tbl.Rows.Count > 0)
            {
                return View("WorkingArea");
            }
            else
            {
                return View("wrong");
            }



        }







        //validateLogin
    }
}