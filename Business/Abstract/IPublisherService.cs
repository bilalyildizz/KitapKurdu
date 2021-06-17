using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPublisherService
    {
        Publisher GetById(int id);

        List<Publisher> GetAll();

    }
}
