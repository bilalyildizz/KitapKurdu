using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Subcategory
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

    }
}
