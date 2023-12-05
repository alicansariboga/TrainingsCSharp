using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Business.@abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
