using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LAB.Authorization.Users;
using LAB.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.Products
{
    public class Product : Entity<long>, ISoftDelete, IHasCreationTime
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
