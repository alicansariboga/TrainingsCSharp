using Project13.Business.@abstract;
using Project13.Data.@abstract;
using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Business.concrete
{
    public class CarManager : ICarService
    {
        private int carHave = 0;
        ICarDao _carDao;
        public CarManager(ICarDao carDao)
        {
            _carDao = carDao;
        }
        public void Add(Car car)
        {
            carAddErrors(car);
        }

        private void carAddErrors(Car car)
        {
            foreach (var item in _carDao.GetAll())
            {
                carHave = item.CarId;
                //Console.WriteLine("In item : " + item.CarId);
                //Console.WriteLine("In charhave : " + carHave);
            }

            // Converting predicate Methods
            /*
            var carAddIdError = _carDao.GetAll().Where(p => p.CarId <= carHave);
            var carAddGeneralError = _carDao.GetAll().Where(p => p.CarModel==null || p.CarBrand==null || p.CarRentCost <= 0 || p.CarSaleCost <= 0 || p.CarProductionYear <= 0);*/
            //Console.WriteLine("Out : " + carHave);
            // for empty fields

            if (car.CarId <= carHave && car.CarId >= 0)
            {
                throw new ServiceMsgException("ERROR. \nRegistration error. The entered ID number is already registered.");
            }
            else if (car.CarModel == null || car.CarBrand == null)
            {
                throw new ServiceMsgException("ERROR. \nRegistration failed. This field is required to be filled.");
            }
            else if (car.CarId < 0 || car.CarRentCost <= 0 || car.CarSaleCost <= 0 || car.CarProductionYear <= 0)
            {
                throw new ServiceMsgException("ERROR. \nRegistration failed. The entered values ​​cannot be less than or equal to 0.");
            }
            else
            {
                Console.WriteLine("Record Number {0} was adding successfully.", car.CarId);
                _carDao.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDao.Delete(car);
            if (car.CarId > carHave && car.CarId < 0)
            {
                throw new ServiceMsgException("ERROR. \nNo such record was found.");
            }
            else
            {
                Console.WriteLine("Record Number {0} was found and the operation was completed successfully.", car.CarId);
                _carDao.Delete(car);
            }
        }
        public void Update(Car car)
        {
            _carDao.Update(car);
        }

        public List<Car> GetAll()
        {
            return _carDao.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDao.GetById();
        }
    }
}
