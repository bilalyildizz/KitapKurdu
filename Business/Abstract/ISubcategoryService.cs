using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISubcategoryService
    {

        List<Subcategory> GetByCategoryId(int id);
        List<Subcategory> GetAll();
        Subcategory GetById(int id);
    
    }
}
