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

namespace UKLON.Controllers
{
    public class HomeController : Controller
    {
        IOrderManager orderManager;
        IMyRandom myRandom;
        
        public HomeController(IOrderManager orderManager, IMyRandom myRandom)
        {
            this.orderManager = orderManager;
            this.myRandom = myRandom;
        }

        public IActionResult Index() => View(new Order());

        public IActionResult InsertData(string AddressFrom, string AddressTo, string Phone)
        {
            int id = 0;
            if (!orderManager.GetAll().Any())
            {
                id += 1;
            }
            else
            {
                id = orderManager.GetAll().Count() + 1;
            }
            var order = new Order { Id = id, AddressFrom = AddressFrom, AddressTo = AddressTo, Phone = Phone, Price = myRandom.GetRandomValue(), IsCanceled = false};
            orderManager.Insert(order);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
