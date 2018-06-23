using EQ_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EQ_Web_Api.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            dynamic data = SampleRepository.getAllData();

            return View(data);
        }

        // GET: Sample/Details/5
        public ActionResult Details(string id)
        {

            dynamic data = SampleRepository.getData(id);

            return View(data);
        }

        // GET: Sample/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sample/Create
        [HttpPost]
        public ActionResult Create(SampleDataModel model)
        {
            try
            {
                
                // TODO: Add insert logic here
                SampleRepository.save(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Edit/5
        public ActionResult Edit(string id)
        {
            dynamic data = SampleRepository.getData(id);

            return View(data);
        }

        // POST: Sample/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, SampleDataModel model)
        {
            try
            {
                // TODO: Add update logic here
                SampleRepository.update(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Delete/5
        public ActionResult Delete(string id)
        {
            dynamic data = SampleRepository.getData(id);

            return View(data);
        }

        // POST: Sample/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                SampleRepository.delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
