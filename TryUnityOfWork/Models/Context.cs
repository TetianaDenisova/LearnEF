using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TryUnityOfWork.Models
{
    public class Context : DbContext
    {
        public Context() : base("Default")
        { }
      public  DbSet<Book> Books { get; set; }
      public  DbSet<Order> Orders { get; set; }
    }
}