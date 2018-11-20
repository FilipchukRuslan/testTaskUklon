using BAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using DAO.Interface;

namespace BAL
{
    public class OrderManager : IOrderManager
    {
        IModelContext modelContext;

        public OrderManager(IModelContext modelContext)
        {
            this.modelContext = modelContext;
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

        public void Update(Order item)
        {
            modelContext.Update(item);
        }
    }
}
