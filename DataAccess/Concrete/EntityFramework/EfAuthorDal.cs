using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAuthorDal : IAuthorDal
    {
        public Author Get(Expression<Func<Author, bool>> filter)
        {

            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {
                return context.Set<Author>().SingleOrDefault(filter);

            }

        }

        public List<Author> GetAll(Expression<Func<Author, bool>> filter = null)
        {
            using (KitapKurduDbContext context= new KitapKurduDbContext())
            {
                return filter == null ? context.Set<Author>().ToList() : context.Set<Author>().Where(filter).ToList();

            }
        }
    }
}
