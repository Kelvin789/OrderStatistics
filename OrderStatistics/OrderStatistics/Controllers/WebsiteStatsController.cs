using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderStatistics.Models;

namespace OrderStatistics.Controllers
{
    public class WebsiteStatsController : Controller
    {
        // GET: WebsiteStats
        public ActionResult Index()
        {
            List<WebsiteStat> list = new List<WebsiteStat>();

            WebsiteStat stats1 = new WebsiteStat
            {
                ID = 1,
                WeekID = 1,
                PageLoadTime = 1.47m,
                UniqueLogins = 16691
            };

            WebsiteStat stats2 = new WebsiteStat
            {
                ID = 2,
                WeekID = 2,
                PageLoadTime = 1.65m,
                UniqueLogins = 16730
            };

            WebsiteStat stats3 = new WebsiteStat
            {
                ID = 3,
                WeekID = 3,
                PageLoadTime = 1.45m,
                UniqueLogins = 16792
            };

            list.Add(stats1);
            list.Add(stats2);
            list.Add(stats3);

            return View(list);
        }

        // GET: WebsiteStats/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebsiteStats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebsiteStats/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebsiteStats/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebsiteStats/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebsiteStats/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebsiteStats/Delete/5
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
