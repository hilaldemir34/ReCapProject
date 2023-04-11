﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 3)
            {
                return new ErrorResult(Messages.InvalidNameError);
            }
           
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorResult(Messages.InvalidNameError);
            }
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Brand>>(Messages.InvalidNameError);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<Brand>(Messages.InvalidNameError);
            }
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Brand>>(Messages.InvalidNameError);
            }
            _brandDal.Update(brand);
            return new SuccessResult();
        }
    }
}
