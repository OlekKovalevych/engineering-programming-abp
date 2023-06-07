using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

