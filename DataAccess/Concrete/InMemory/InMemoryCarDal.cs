using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                   Id=1,BrandId=2,ColorId=3,DailyPrice=380000.00,ModelYear="2022",Description="Toyoto"

                },
              new Car
              {
                  Id = 2,
                  BrandId = 1,
                  ColorId = 2,
                  DailyPrice = 500000.00,
                  ModelYear = "2020",
                  Description = "Audi"
              },
                new Car
                {
                   Id=3,BrandId=2,ColorId=3,DailyPrice=250000.00,ModelYear="2019",Description="Mercedes" },


              new Car
              {
                  Id = 1,
                  BrandId = 4,
                  ColorId = 4,
                  DailyPrice = 100000.00,
                  ModelYear = "2018",
                  Description = "Hyundai"
              },        
    };

    }

    public void Add(Car car)
    {
            _cars.Add(car);
    }

    public void Delete(Car car)
    {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
    }

    public List<Car> GetAll()
    {
            return _cars;
    }

    public Car GetById(int id)
    {
            return (Car)_cars.Where(p => p.Id == id);
    }

    public void Update(Car car)
    {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
           

    }
}
}
