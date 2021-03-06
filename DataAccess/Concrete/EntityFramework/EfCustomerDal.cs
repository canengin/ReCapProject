using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, CarRental>,ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarRental context = new CarRental())
            {
               var result = from u in context.Users
                             join c in context.Customers
                             on u.ID equals c.UserID
                             select new CustomerDetailDto
                             {
                               Id = u.ID,
                               FirstName = u.FirstName,
                               LastName = u.LastName,
                               Email = u.Email,
                               CompanyName = c.CompanyName
                            };
                return result.ToList();
            }
        }
    }
}
