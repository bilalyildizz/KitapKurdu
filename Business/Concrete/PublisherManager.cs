using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }


        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }

        public Publisher GetById(int id)
        {
            return _publisherDal.Get(p => p.Id == id);
        }
    }
}
