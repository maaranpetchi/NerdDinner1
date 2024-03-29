﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Models;
namespace NerdDinner.Controllers
{
    public class EmpController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        // GET: Emp
        public ActionResult Index()
        {
            var getemprecords = dc.crudemp(null, null, null, null, null, null, null, null, null, null, "Select").ToList();
            return View(getemprecords);
        }

        // GET: Emp/Details/5
        public ActionResult Details(int id)
        {
            var empdetails = dc.crudemp(id, null, null, null, null, null, null, null, null, null, "Details").Single(x => x.DinnerID == id);
            return View(empdetails);
        }

        // GET: Emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult Create(EmpClass collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.crudemp(null, collection.Title, collection.EventDate, collection.Description, collection.HostedBy, collection.ContactPhone, collection.Address, collection.Country, collection.Latitude, collection.Longitude,"Insert");
               dc.SubmitChanges();
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Edit/5
        public ActionResult Edit(int id)
        {
            var empdetails = dc.crudemp(id, null, null, null, null, null, null, null, null, null, "Details").Single(x => x.DinnerID == id);
            return View(empdetails);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmpClass collection)
        {
            try
            {
                // TODO: Add update logic here
                dc.crudemp(id, collection.Title, collection.EventDate, collection.Description, collection.HostedBy, collection.ContactPhone, collection.Address, collection.Country, collection.Latitude, collection.Longitude, "Update");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            var empdetails = dc.crudemp(id, null, null, null, null, null, null, null, null, null, "Details").Single(x => x.DinnerID == id);
            return View(empdetails);
        }

         // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, EmpClass collection)
        {
            try
            {
                // TODO: Add delete logic here
                dc.crudemp(id, null, null, null, null, null, null, null, null, null, "Delete");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
