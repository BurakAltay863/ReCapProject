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
    public class EfBrandDal : IBrandDal
    {
       
        public void Add(Brand entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var deletededEntity = context.Entry(entity);
                deletededEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            
            using ReCapProjectContext context = new ReCapProjectContext();
            return context.Set<Brand>().SingleOrDefault(filter);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using ReCapProjectContext context = new ReCapProjectContext();
            return filter == null
                ? context.Set<Brand>().ToList()
                : context.Set<Brand>().Where(filter).ToList();
        }

        public void Update(Brand entity)
        {
            using ReCapProjectContext context = new ReCapProjectContext();
            var updatededEntity = context.Entry(entity);
            updatededEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}