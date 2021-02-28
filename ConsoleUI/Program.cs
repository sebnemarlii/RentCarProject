using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car);
            }

            //Console.WriteLine("Eklemek istediğiniz arabanın bilgileri:");
            //Console.WriteLine("Color Id:");
            //int colorIdForAddition = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Brand Id:");
            //int brandIdForAddition = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Model Year:");
            //string modelYearForAddition = Console.ReadLine();
            //Console.WriteLine("Daily Price:");
            //decimal dailyPriceForAddition = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Description:");
            //string descriptionForAddition = Console.ReadLine();
            //Car carForAdd = new Car {BrandId = brandIdForAddition, ColorId = colorIdForAddition, DailyPrice = dailyPriceForAddition, Description = descriptionForAddition, ModelYear = modelYearForAddition };
            //carManager.Add(carForAdd);
        }
    }
}
