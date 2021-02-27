using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=4,ModelYear=2010,DailyPrice=150,Description="Standart Paket" },
                new Car{CarId=2,BrandId=2,ColorId=3,ModelYear=2015,DailyPrice=200,Description="Full Paket" },
                new Car{CarId=3,BrandId=3,ColorId=1,ModelYear=2017,DailyPrice=70,Description="Standart Paket" },
                new Car{CarId=4,BrandId=4,ColorId=2,ModelYear=2003,DailyPrice=150,Description="-----" },
                new Car{CarId=5,BrandId=2,ColorId=1,ModelYear=2008,DailyPrice=50,Description="Standart Paket" }
            };
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == entity.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetByBrandId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();

        }

        public List<Car> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == entity.CarId);

            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.Description = entity.Description;
        }
    }
}
