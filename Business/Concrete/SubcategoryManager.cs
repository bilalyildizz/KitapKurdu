using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SubcategoryManager : ISubcategoryService
    {
        ISubcategoryDal _subcategoryDal;

        public SubcategoryManager(ISubcategoryDal subcategoryDal)
        {
            _subcategoryDal = subcategoryDal;

        }


        public List<Subcategory> GetAll()
        {
            return _subcategoryDal.GetAll();
        }

        public List<Subcategory> GetByCategoryId(int id)
        {
            return _subcategoryDal.GetAll(s => s.CategoryId == id);
        }

        public Subcategory GetById(int id)
        {
           return  _subcategoryDal.Get(s => s.Id == id);
        }
    }
}
