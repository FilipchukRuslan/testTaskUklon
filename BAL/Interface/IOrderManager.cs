using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Interface
{
    public interface IOrderManager
    {
        List<Order> GetAll();
        Order GetById(int id);
        void Insert(Order item);
        void Update(Order item);
        void Delete(Order item);
        Order SetOrderValues(string AddressFrom, string AddressTo, string Phone);
        void CancelOrder(bool isCanceled, int id);
    }
}
