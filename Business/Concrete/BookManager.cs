using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetBookByAuthorId(int id)
        {
            return _bookDal.GetAll(u => u.AuthorId == id);
        }

        public Book GetBookById(int id)
        {
            return _bookDal.Get(u => u.Id == id);
        }

        public List<Book> GetBookByPublisherId(int id)
        {
            return _bookDal.GetAll(u => u.PublisherId == id);
        }

        public List<Book> GetBookBySubcategoryId(int id)
        {
            return _bookDal.GetAll(u => u.SubCategoryId == id);
        }
    }
}
