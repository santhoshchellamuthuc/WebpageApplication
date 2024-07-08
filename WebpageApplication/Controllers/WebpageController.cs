using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webpagemodeol;

namespace WebpageApplication.Controllers
{
    public class WebpageController : Controller
    {
        public IRepostery refer;
        public WebpageController(IRepostery reference)
        {
            refer = reference;
        }
        // GET: WebpageController
        public ActionResult Index()
        {
            return View("list",refer.Show());
        }

        // GET: WebpageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebpageController/Create
        public ActionResult Create()
        {
            try
            {
                var model = new webpagemodel();
                return View("Insert", model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // POST: WebpageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(webpagemodel insert)
        {
            try
            {
                refer.Create(insert);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: WebpageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebpageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WebpageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebpageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
