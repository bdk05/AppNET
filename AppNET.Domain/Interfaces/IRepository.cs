using AppNET.Domain.Entities;
using AppNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        bool Remove(int id);
        T GetById(int id1);
        //varsayilan değeri null olan bir fonksiyon alacak
        ICollection<T> GetList(Func<T,bool> expression=null);
        T Update(int id, T entity);
        //void Update(Func<object, object> value);
    }
    
}
