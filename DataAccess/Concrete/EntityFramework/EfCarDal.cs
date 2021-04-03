using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRental>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRental context = new CarRental())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandID equals b.ID
                             join co in context.Colors
                             on c.ColorID equals co.ID
                             join ci in context.CarImages
                             on c.ID equals ci.CarID
                             select new CarDetailDto { 
                                 CarID = c.ID, 
                                 CarName = c.Name, 
                                 BrandName = b.Name, 
                                 ColorName = co.Name, 
                                 DailyPrice = c.DailyPrice, 
                                 Description = c.Description, 
                                 IsRented = c.IsRented, 
                                 ModelYear = c.ModelYear,
                                 ImagePath=ci.ImagePath,
                                 BrandID = b.ID,
                                 ColorID = co.ID
                             };
                return result.ToList();
            }
        }
    }
}
