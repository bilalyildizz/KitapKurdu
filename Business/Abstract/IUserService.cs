using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {

        User GetByEmail(string email);

        void Add(User user);
       

    }
}
