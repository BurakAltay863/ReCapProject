using Buisness.Concrete;
using DataAcsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManeger carManeger = new CarManeger(new InMemoryCarDal());

            foreach (var car in carManeger.GetAll())
            {
                Console.WriteLine("ArabaIdsı:" + car.CarId + " Açıklama:" + car.Description);


            }

        }
    }
}
