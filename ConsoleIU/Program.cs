using Business.Concrete;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramwork;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            //Update();

            //Add();

            //Delate();

            //GetAll();

            //GetById();

        }

        private static void GetById()
        {
            CarManeger carManeger = new CarManeger(new EfCarDal());

            foreach (var c in carManeger.GetById(3))
            {
                Console.WriteLine(c.CarName);
            }
        }

        private static void GetAll()
        {
            CarManeger carManeger = new CarManeger(new EfCarDal());

            foreach (var c in carManeger.GetAll())
            {
                Console.WriteLine(c.CarName);
            }
        }

        private static void Delate()
        {
            Car car = new Car { CarId = 2 };
            CarManeger carManeger = new CarManeger(new EfCarDal());
            carManeger.Delete(car);
            foreach (var c in carManeger.GetCarDetails())
            {
                Console.WriteLine(c.CarName + " " + c.BrandName + " " + c.ColorName + " " + c.DailyPrice + " " + c.ModelYear);
            }
        }

        private static void Add()
        {
            Car car = new Car { BrandId = 1, CarName = "asd", ColorId = 1, DailyPrice = 500, Description = "hasarlı", ModelYear = "2012" };
            CarManeger carManeger = new CarManeger(new EfCarDal());
            carManeger.Add(car);
            foreach (var c in carManeger.GetCarDetails())
            {
                Console.WriteLine(c.CarName + " " + c.BrandName + " " + c.ColorName + " " + c.DailyPrice + " " + c.ModelYear);
            }
        }

        private static void Update()
        {
            Car car = new Car { CarId = 2, BrandId = 1, CarName = "kkd", ColorId = 1, DailyPrice = 200, Description = "temiz", ModelYear = "2012" };
            CarManeger carManeger = new CarManeger(new EfCarDal());
            carManeger.Update(car);
            foreach (var c in carManeger.GetCarDetails())
            {
                Console.WriteLine(c.CarName + " " + c.BrandName + " " + c.ColorName + " " + c.DailyPrice + " " + c.ModelYear);
            }
        }
    }
}
