﻿using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager:IBrandService
    {
        EFBrandDal _brand;

        public void Add(Brand brand)
        {
            _brand.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brand.Delete(brand);
        }

        public void Update(Brand brand)
        {
            _brand.Update(brand);
        }

        public BrandManager(EFBrandDal brand)
        {
            _brand = brand;
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetByBrandId(int ıd)
        {
            return _brand.GetAll(p=>p.BrandId==ıd);
        }
    }
}
