using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManeger : IColorService
    {
        IColorDal _colorDal;
        public ColorManeger(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }


        public void Add(Color color)
        {
            _colorDal.Add(color);

        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine(color.ColorId + "=No Idli araba silindi");
        }


        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetById(int colorId)
        {
            return _colorDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine(color + "=No Idli araba güncellendi");
        }
    }
}

