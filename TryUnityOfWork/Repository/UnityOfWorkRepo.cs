using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryUnityOfWork.Models;

namespace TryUnityOfWork.Repository
{
    public class UnityOfWorkRepo : IDisposable
    {
        private BookRepository BooksRepo { get; set; }
        private OrderRepository OrdersRepo { get; set; }
        Context context = new Context();
        public BookRepository Books
        {
            get
            {
                if (BooksRepo == null)
                    BooksRepo = new BookRepository();
                return BooksRepo;
            }
        }
        public OrderRepository Orders
        {
            get
            {
                if (OrdersRepo == null)
                    OrdersRepo = new OrderRepository();
                return OrdersRepo;
            }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}