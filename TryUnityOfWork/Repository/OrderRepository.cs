using System.Collections.Generic;
using System.Linq;
using TryUnityOfWork.Models;
using System.Data.Entity;
namespace TryUnityOfWork
{
    public class OrderRepository : IRepository<Order>
    {
        Context context = new Context();
        public IEnumerable<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public Order GetById(int Id)
        {
            return context.Orders.Where(x => x.Id == Id).FirstOrDefault();
        }

        public Order Create(Order obj)
        {
            context.Orders.Add(obj);
            return obj;
        }

        public Order Update(Order updateO)
        {
            context.Orders.Add(updateO);
            context.Entry(updateO).State = EntityState.Modified;
            return updateO;
        }

        public Order Delete(Order deleteO)
        {
            context.Orders.Remove(deleteO);
            context.Entry(deleteO).State = EntityState.Deleted;
            return deleteO;
        }
    }
}