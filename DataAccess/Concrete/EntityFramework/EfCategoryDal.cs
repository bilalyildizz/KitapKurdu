using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);

            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {
                return filter == null ? context.Set<Category>().ToList() : context.Set<Category>().Where(filter).ToList();
            }
        }
    }
}
