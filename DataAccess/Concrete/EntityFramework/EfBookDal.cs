using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : IBookDal
    {
        public Book Get(Expression<Func<Book, bool>> filter)
        {
            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {

                return context.Set<Book>().SingleOrDefault(filter); 

            }
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {

            using (KitapKurduDbContext context = new KitapKurduDbContext())
            {

                return filter == null ? context.Set<Book>().ToList() : context.Set<Book>().Where(filter).ToList();


            }
        }
    }
}
