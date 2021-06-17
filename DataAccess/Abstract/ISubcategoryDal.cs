using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISubcategoryDal
    {

        Subcategory Get(Expression<Func<Subcategory, bool>> filter);
        List<Subcategory> GetAll(Expression<Func<Subcategory, bool>> filter=null);

    }
}
