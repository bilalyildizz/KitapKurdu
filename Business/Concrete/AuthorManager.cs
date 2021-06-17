using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal) 
        {
            _authorDal = authorDal;
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorDal.Get(a=>a.Id==id);
        }
    }
}
