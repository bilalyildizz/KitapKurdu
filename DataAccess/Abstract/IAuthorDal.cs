using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAuthorDal
    {
        Author Get(Expression<Func<Author, bool>> filter);


        List<Author> GetAll(Expression<Func<Author, bool>> filter=null);

    }
}
