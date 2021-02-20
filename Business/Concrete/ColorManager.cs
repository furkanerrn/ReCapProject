using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ColorManager : IColorService
    {
        EFColorDal _color;

        public void Add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
            _color.Delete(color);
        }

        public void Update(Color color)
        {
            _color.Update(color);
        }

        public ColorManager(EFColorDal color)
        {
            _color = color;
        }

        public List<Color> GetAll()
        {
            return _color.GetAll();
        }

        public List<Color> GetAllByColor(int Colorıd)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetColorId(int Colorıd)
        {
            return _color.GetAll(p => p.ColorId == Colorıd);
        }

       

       

       


    }
}
