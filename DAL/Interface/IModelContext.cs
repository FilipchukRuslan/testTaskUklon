using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAO.Interface
{
    public interface IModelContext
    {
        List<Order> GetAll();
        Order GetById(int id);
        void Insert(Order item);
        void Update(Order item);
        void Delete(Order item);
    }
}
