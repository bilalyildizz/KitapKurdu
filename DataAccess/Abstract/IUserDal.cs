using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Auth manager ve user manager ayrı ayrı oluşturmalımıyım ? 
    public interface IUserDal
    {
       
        User Get(Expression<Func<User, bool>> filter);
        void Add(User user);

        

    }
}
