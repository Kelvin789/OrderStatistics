using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderStatistics.Models;

namespace OrderStatistics.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            List<Orders> list = new List<Orders>();

            Orders order1 = new Orders
            {
                ID = 1,
                WeekID = 100,
                OrdersPlaced = 22217,
                OrdersAuthorised = 21414,
                TotalSales = 1197709.28m
            };

            Orders order2 = new Orders
            {
                ID = 2,
                WeekID = 101,
                OrdersPlaced = 22739,
                OrdersAuthorised = 21767,
                TotalSales = 963445.69m
            };

            Orders order3 = new Orders
            {
                ID = 2,
                WeekID = 102,
                OrdersPlaced = 22283,
                OrdersAuthorised = 21707,
                TotalSales = 964347.70m
            };

            list.Add(order1);
            list.Add(order2);
            list.Add(order3);

            return View(list);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            return View();
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
            return View();
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
    }
}
