using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        public void Add(User user)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {

                var addedEntity = context.Entry(user);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }

        }

       
    }
}
