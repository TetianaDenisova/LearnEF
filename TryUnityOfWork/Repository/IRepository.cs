using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryUnityOfWork.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        T Create(T obj);
        T Update(T updateO);
        T Delete(T deleteO);
    }
}