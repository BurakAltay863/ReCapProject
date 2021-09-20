using Buisness.Abstract;
using DataAcsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Concrete
{
    public class CarManeger : ICarService
    {
        ICarDal _carDal;
        public CarManeger(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine(car.CarId + "=No Idli araba eklendi");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.CarId + "=No Idli araba silindi");
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        public List<Car> GetById(int carId)
        {
            return _carDal.GetById(carId);


        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.CarId + "=No Idli araba güncellendi");
        }

    }
}
