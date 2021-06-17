using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubCategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public bool IsHired { get; set; }
        public string ImagePath { get; set; }
        public string Detail { get; set; }

    }
}
