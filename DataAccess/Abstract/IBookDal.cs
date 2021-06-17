using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBookDal
    {
        Book Get(Expression<Func<Book, bool>> filter);
        List<Book> GetAll(Expression<Func<Book, bool>> filter =null);

        
    }
}
