using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(string id);
        List<Car> GetByDailyPrice(decimal dailyPrice);
        List<CarDetailDto> GetCarDetails();


    }
}
