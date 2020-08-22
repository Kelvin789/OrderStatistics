using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderStatistics.Models;

namespace OrderStatistics.Controllers
{
    public class WebsiteStatisticsController : Controller
    {
        // GET: WebsiteStats
        public ActionResult Index()
        {
            return View(HardCodedList());
        }

        // GET: WebsiteStats/Details/5
        public ActionResult Details(int id)
        {
            List<Website> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
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
            List<Website> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
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
            List<Website> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
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

        public List<Website> HardCodedList()
        {
            List<Website> list = new List<Website>();

            Website stats1 = new Website
            {
                Id = 1,
                WeekId = 1,
                PageLoadTime = 1.47m,
                UniqueLogins = 16691
            };

            Website stats2 = new Website
            {
                Id = 2,
                WeekId = 2,
                PageLoadTime = 1.65m,
                UniqueLogins = 16730
            };

            Website stats3 = new Website
            {
                Id = 3,
                WeekId = 3,
                PageLoadTime = 1.45m,
                UniqueLogins = 16792
            };

            Website stats4 = new Website
            {
                Id = 4,
                WeekId = 4,
                PageLoadTime = 4.45m,
                UniqueLogins = 1668
            };

            list.Add(stats1);
            list.Add(stats2);
            list.Add(stats3);
            list.Add(stats4);

            return list;
        }
    }
}
