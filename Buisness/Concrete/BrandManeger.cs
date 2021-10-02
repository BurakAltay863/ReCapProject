using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManeger : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManeger(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine(brand.BrandName + "Adlı Araba Markası Eklendi");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine(brand.BrandName + "Adlı Araba Markası Silindi");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();

        }

        public List<Brand> GetById(int brandId)
        {
            return _brandDal.GetAll(b => b.BrandId == brandId);

        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine(brand.BrandName+"Adlı Araba Markası Güncellendi");
        }
    }
}
