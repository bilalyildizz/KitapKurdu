using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {

        Book GetBookById(int id);
        List<Book> GetAll();
        List<Book> GetBookBySubcategoryId(int id);
        List<Book> GetBookByPublisherId(int id);
        List<Book> GetBookByAuthorId(int id);

    }
}
