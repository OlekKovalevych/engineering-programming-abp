using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Categories.Dto
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

