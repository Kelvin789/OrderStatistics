using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderStatistics.Models;

namespace OrderStatistics.Controllers
{
    public class RefundedStatisticsController : Controller
    {
        // GET: RefundedStatistics
        public ActionResult Index()
        {        
            return View(HardCodedList());
        }

        // GET: RefundedStatistics/Details/5
        public ActionResult Details(int id)
        {
            List<Refunded> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
        }

        // GET: RefundedStatistics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RefundedStatistics/Create
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

        // GET: RefundedStatistics/Edit/5
        public ActionResult Edit(int id)
        {
            List<Refunded> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
        }

        // POST: RefundedStatistics/Edit/5
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

        // GET: RefundedStatistics/Delete/5
        public ActionResult Delete(int id)
        {
            List<Refunded> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
        }

        // POST: RefundedStatistics/Delete/5
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

        public List<Refunded> HardCodedList()
        {
            List<Refunded> list = new List<Refunded>();

            Refunded refunded1 = new Refunded
            {
                Id = 1,
                WeekId = 101,
                TotalQuantity = 200,
                TotalDamagedUnit = 90,
                TotalCost = 19920.99m

            };

            Refunded refunded2 = new Refunded
            {
                Id = 21,
                WeekId = 102,
                TotalQuantity = 110,
                TotalDamagedUnit = 123,
                TotalCost = 60329.84m
            };

            Refunded refunded3 = new Refunded
            {
                Id = 3,
                WeekId = 103,
                TotalQuantity = 384,
                TotalDamagedUnit = 245,
                TotalCost = 43453.23m
            };

            Refunded refunded4 = new Refunded
            {
                Id = 4,
                WeekId = 104,
                TotalQuantity = 456,
                TotalDamagedUnit = 12,
                TotalCost = 234564.94m
            };

            Refunded refunded5 = new Refunded
            {
                Id = 5,
                WeekId = 105,
                TotalQuantity = 12,
                TotalDamagedUnit = 1,
                TotalCost = 1090.30m
            };

            list.Add(refunded1);
            list.Add(refunded2);
            list.Add(refunded3);
            list.Add(refunded4);
            list.Add(refunded5);

            return list;
        }
    } 
}