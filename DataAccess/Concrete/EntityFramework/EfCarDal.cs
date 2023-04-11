using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(ReCapContext context=new ReCapContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors
                             on p.Id equals c.ColorId
                             select new CarDetailDto
                             {
                                 CarId = p.Id,ColorName=c.ColorName

                             };
                return result.ToList();

            }
        }
    }
}
