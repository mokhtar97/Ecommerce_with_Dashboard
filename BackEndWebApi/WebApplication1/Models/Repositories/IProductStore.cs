using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Repositories
{
    public interface IProductStore<T>
    {
        ICollection<T> List();
        T Find(int id);

        void ADD(T Model);
        void Update(int id, T Model);
        void Delete(int id);
    }
}