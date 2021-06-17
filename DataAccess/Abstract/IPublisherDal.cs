using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPublisherDal
    {
        Publisher Get(Expression<Func<Publisher, bool>> filter);

        List<Publisher> GetAll(Expression<Func<Publisher, bool>> filter = null);


    }
}
