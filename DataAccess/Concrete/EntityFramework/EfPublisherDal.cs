using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPublisherDal : IPublisherDal
    {
        public Publisher Get(Expression<Func<Publisher, bool>> filter)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {
                return context.Set<Publisher>().SingleOrDefault(filter);

            }
        }

        public List<Publisher> GetAll(Expression<Func<Publisher, bool>> filter = null)
        {

            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {
                return filter == null ? context.Set<Publisher>().ToList() : context.Set<Publisher>().Where(filter).ToList();

            }


        }
    }
}
