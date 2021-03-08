using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        ICarService _carService;
        public CarImageManager(ICarImageDal carImageDal,ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage,IFormFile file)
        {
            IResult res = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            if (res != null)
            {
                return res;
            }
            //if (file!=null)
            //{
            carImage.ImagePath = FileHelper.Add(file);

            //}
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImagesAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            IResult res = BusinessRules.Run(CarImageDelete(carImage));
            if (res!=null)
            {
                return res;
            }
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImagesDeleted);
        }

        public IDataResult<CarImage> Get(int id)
        {
            return new SuccesDataResult<CarImage>(_carImageDal.Get(p => p.Id == id), Messages.AllCarImagesListed);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccesDataResult<List<CarImage>>(_carImageDal.GetAll(),Messages.AllCarImagesListed);
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            return new SuccesDataResult<List<CarImage>>(CheckIfCarImageNull(id), Messages.CarListedByCarId);
        }

        public IResult Update(CarImage carImage,IFormFile file)
        {
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(p => p.Id == carImage.Id).ImagePath, file);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }




        //business rules
        private IResult CheckImageLimitExceeded(int carid)
        {
            var carImagecount = _carImageDal.GetAll(p => p.CarId == carid).Count;
            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }

            return new SuccessResult();
        }

        //Business Rules
        private List<CarImage> CheckIfCarImageNull(int carId)
        {
            //default bir path oluştur
            string path = @"\Images\carLogo.jpg";

            //Car tablosundan Id'ye göre obje çek. (_carImage =>Ctor'da CarService injection ile sağlanır.)
            Car carData = _carService.GetCarById(carId).Data;

            //çekilen datayı, CarImage tablosunda dön
            var result = _carImageDal.GetAll(c => c.CarId == carData.CarId).Any();

            //eğer carImage tablosunda verilen Id'de Car yok ise default verilen ImagePath'i göster. 
            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now } };
            }
            return _carImageDal.GetAll(p => p.CarId == carId);
        }

        private IResult CarImageDelete(CarImage carImage)
        {
            try
            {
                File.Delete(carImage.ImagePath);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
    }
}
