using Buisness.Concrete;
using DataAcsess.Concrete.EntityFramwork;
using DataAcsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManeger carManeger = new CarManeger(new EfCarDal());

            //foreach (var car in carManeger.GetAll())
            //{
            //    Console.WriteLine("ArabaIdsı:" + car.CarId + " Açıklama:" + car.Description);

                
            //}
            Car car1 = new Car();
            car1.CarName = "Massarati";
            car1.DailyPrice = 25;
            car1.CarId = 1;

            Car car2 = new Car();
            car2.CarName = "a";
            car2.DailyPrice = 20;
            car2.CarId = 2;
            carManeger.Add(car1);
            carManeger.Add(car2);
            
            
        }
    }
}
