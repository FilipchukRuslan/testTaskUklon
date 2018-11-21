using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BAL;
using BAL.Interface;
using Common;
using Common.Interface;
using Microsoft.AspNetCore.Mvc;
using Model;
using UKLON.Models;
using UKLON.ViewModel;

namespace UKLON.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderManager orderManager;
        
        public HomeController(IOrderManager orderManager)
        {
            this.orderManager = orderManager;
        }

        public IActionResult Index() => View(new Order());

        public IActionResult InsertData(string AddressFrom, string AddressTo, string Phone)
        {
            var order = orderManager.SetOrderValues(AddressFrom, AddressTo, Phone);
            orderManager.Insert(order);
            return RedirectToAction("Index");
        }

        public IActionResult ShowOrders() => View(orderManager.GetAll());

        public IActionResult EditOrder(int Id) => View(orderManager.GetById(Id));

        public IActionResult UpdateOrder(Order order)
        {
            orderManager.Update(order);
            return RedirectToAction("ShowOrders", "Home", orderManager.GetAll());
        }

        public IActionResult CancelOrder(CancelOrderVM cancelOrder)
        {
            orderManager.CancelOrder(cancelOrder.Flag, cancelOrder.OrderId);
            return RedirectToAction("ShowOrders", "Home", orderManager.GetAll());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
