﻿using Core.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramwork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapProjectContext>, IColorDal
    {
       
    }
}
