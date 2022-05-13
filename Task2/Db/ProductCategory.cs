using System;
using System.Collections.Generic;

namespace Task2.Db
{
    public partial class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
