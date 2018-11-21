using BAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using DAO.Interface;
using Common.Interface;
using System.Linq;

namespace BAL
{
    public class OrderManager : IOrderManager
    {
        IModelContext modelContext;
        IMyRandom myRandom;
        public OrderManager(IModelContext modelContext, IMyRandom myRandom)
        {
            this.modelContext = modelContext;
            this.myRandom = myRandom;
        }

        public void Delete(Order item)
        {
            modelContext.Delete(item);
        }

        public List<Order> GetAll()
        {
            return modelContext.GetAll();
        }

        public Order GetById(int id)
        {
            return modelContext.GetById(id);
        }

        public void Insert(Order item)
        {
            modelContext.Insert(item);
        }

        public Order SetOrderValues(string AddressFrom, string AddressTo, string Phone)
        {
            int id = 0;
            if (!GetAll().Any())
            {
                id += 1;
            }
            else
            {
                id = GetAll().Count() + 1;
            }
            var order = new Order { Id = id, AddressFrom = AddressFrom, AddressTo = AddressTo, Phone = Phone, Price = myRandom.GetRandomValue(), IsCanceled = false };

            return order;
        }

        public void Update(Order item)
        {
            //var order = GetById(item.Id);
            //order.AddressFrom = item.AddressFrom;
            //order.AddressTo = item.AddressTo;
            //order.Phone = item.Phone;
            //order.Price = item.Price;

            modelContext.Update(item);
        }
    }
}
