using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryUnityOfWork.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}