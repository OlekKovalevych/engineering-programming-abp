using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LAB.Authorization.Users;
using LAB.Products;
using System;
using System.Collections.Generic;

namespace LAB.Categories
{
    public class Category : Entity<long>, ISoftDelete, IHasCreationTime
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }

        public long UserId { get; set; }
        public virtual User User { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
