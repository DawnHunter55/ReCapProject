﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfRentDal: EfEntityRepositoryBase<Rental, RecapDbContext>,IRentalDal
    {
        public List<RentDetailsDto> GetRentDetails()
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentDetailsDto
                             {
                                 CarBrand = b.BrandName,
                                 CarColor = co.ColorName,
                                 CarName = c.Name,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName
                             };
                return result.ToList();


            }
        }
    }
}
