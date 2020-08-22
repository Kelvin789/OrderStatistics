using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderStatistics.Models;

namespace OrderStatistics.Controllers
{
    public class OrderStatisticsController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View(HardCodedList());
        }

        // GET: Order/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            // Uses hardcoded list - would find id in against db to view record
            List<Order> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
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

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            List<Order> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
        }

        // POST: Order/Edit/5
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

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            List<Order> list = HardCodedList();
            return View(list.Find(x => x.Id.Equals(id)));
        }

        // POST: Order/Delete/5
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

        public List<Order> HardCodedList()
        {
            List<Order> list = new List<Order>();

            Order order1 = new Order
            {
                Id = 1,
                WeekId = 100,
                OrdersPlaced = 22217,
                OrdersAuthorised = 21414,
                TotalSales = 1197709.28m
            };

            Order order2 = new Order
            {
                Id = 2,
                WeekId = 101,
                OrdersPlaced = 22739,
                OrdersAuthorised = 21767,
                TotalSales = 963445.69m
            };

            Order order3 = new Order
            {
                Id = 3,
                WeekId = 102,
                OrdersPlaced = 22283,
                OrdersAuthorised = 21707,
                TotalSales = 964347.70m
            };

            list.Add(order1);
            list.Add(order2);
            list.Add(order3);

            return list;
        }
    }
}
