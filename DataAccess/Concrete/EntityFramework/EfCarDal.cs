using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,EntityContext> ,ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (EntityContext context = new EntityContext())
            {

                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join a in context.Colors on c.ColorId equals a.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.Name,
                                 ColorName = a.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
        }


    }
}
