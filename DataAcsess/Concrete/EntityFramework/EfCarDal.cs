﻿using DataAcsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcsess.Concrete.EntityFramwork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
               
            }
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using ReCapProjectContext context = new ReCapProjectContext();
            return context.Set<Car>().SingleOrDefault(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using ReCapProjectContext context = new ReCapProjectContext();
            return filter == null
                ? context.Set<Car>().ToList()
                : context.Set<Car>().Where(filter).ToList();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}