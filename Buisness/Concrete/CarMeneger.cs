using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
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
            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                Console.WriteLine(car.CarId + "=No Idli araba eklendi");
            }

            else
            {
                Console.WriteLine(car.CarId+"=no Idlı araba eklenemedı");
            }
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
            return _carDal.GetAll(c => c.CarId == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.CarId + "=No Idli araba güncellendi");
        }

    }
}
