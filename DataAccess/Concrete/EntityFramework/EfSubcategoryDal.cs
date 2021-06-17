using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSubcategoryDal : ISubcategoryDal
    {
        public Subcategory Get(Expression<Func<Subcategory, bool>> filter)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {
                return context.Set<Subcategory>().SingleOrDefault(filter);

            }
        }

        public List<Subcategory> GetAll(Expression<Func<Subcategory, bool>> filter = null)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext()) 
            {

                return filter == null ? context.Set<Subcategory>().ToList() : context.Set<Subcategory>().Where(filter).ToList();

            }
        }
    }
}
