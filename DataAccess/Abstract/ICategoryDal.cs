using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);

        Category Get(Expression<Func<Category, bool>> filter);
            
    }
}
