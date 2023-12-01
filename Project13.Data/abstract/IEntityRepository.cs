using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Data.@abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll();
        List<T> GetById();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
