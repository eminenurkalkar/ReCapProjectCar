using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
          _cars = new List<Car> { 
          new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=900000,Description="Range Rower",ModelYear=2016},
          new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=450000,Description="Audi Q7",ModelYear=2011},
          new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=650000,Description="BMW X6",ModelYear=2016},
            };


        }
        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.DailyPrice = car.DailyPrice;

        }
    }
}
