using DAO.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAO
{
    public class ModelContext : IModelContext //in this case its not neccessary to use interface without templates like ( <T> where T : class ), but left it in case if need to change the right way using Database entities   
    {
        public List<Order> Orders = new List<Order>();

        public List<Order> GetAll()
        {
            return Orders;
        }
        public Order GetById(int id)
        {
            return Orders.Where(e => e.Id == id).FirstOrDefault();
        }
        
        public void Insert(Order item)
        {
            Orders.Add(item);
        }
        public void Update(Order item)
        {
            var entity = Orders.Where(e => e.Id == item.Id).FirstOrDefault();
            var index = Orders.IndexOf(entity);
            Orders.RemoveAt(index);
            Orders.Insert(index, item);
        }
        public void Delete(Order item)
        {
            var entity = Orders.Where(e => e.Id == item.Id).FirstOrDefault();
            Orders.RemoveAt(Orders.IndexOf(entity));
        }
    }
}
