using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ColorManager : IColorService
    {
        IColorDAL _color;
        public ColorManager(IColorDAL color)
        {
            _color = color;
        }


        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);
            _color.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _color.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

       

        public IResult Update(Color color)
        {
            _color.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

       

        public IDataResult<List<Color>> GetAll()
        {

            return new SuccesDataResult<List<Color>>(_color.GetAll(), Messages.ColorsListed);
        }

       

        public  IDataResult<List<Color>> GetColorId(int colorıd)
        {
            return new SuccesDataResult<List<Color>>(_color.GetAll(p => p.ColorId ==colorıd),Messages.ColorsListedById);
        }

       

       

       


    }
}
