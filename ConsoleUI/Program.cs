using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
            //ColorMethod();
        }

        private static void ColorMethod()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void NewMethod()
            {
                CarManager carManager = new CarManager(new EfCarDal(),new ColorManager(new EfColorDal()));
                foreach (var car in carManager.GetCarDetails().Data )
                {
                    Console.WriteLine(car.CarId+" "+car.ColorName);
                }
            }
        }
    }
