﻿using Core.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramwork
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,ReCapProjectContext>,IBrandDal
    {
       
      
    }
}
