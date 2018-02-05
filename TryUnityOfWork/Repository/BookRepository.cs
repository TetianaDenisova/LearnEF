using System.Collections.Generic;
using System.Linq;
using TryUnityOfWork.Models;
using System.Data.Entity;
namespace TryUnityOfWork
{
    public class BookRepository : IRepository<Book>
    {
        Context context = new Context();
        public IEnumerable<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public Book GetById(int Id)
        {
            return context.Books.Where(x => x.Id == Id).FirstOrDefault();
        }

        public Book Create(Book obj)
        {
            context.Books.Add(obj);
            return obj;
        }

        public Book Update(Book updateO)
        {
            context.Books.Add(updateO);
            context.Entry(updateO).State = EntityState.Modified;
            return updateO;
        }

        public Book Delete(Book deleteO)
        {
            context.Books.Remove(deleteO);
            context.Entry(deleteO).State = EntityState.Deleted;
            return deleteO;
        }
    }
}