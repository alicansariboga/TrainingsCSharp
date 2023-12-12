using Project15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15.Data.@abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //
        List<T> GetAll();
        T GetById(int msgId);
        void Add(T entity);
        void Delete(T entity);
    }
}
