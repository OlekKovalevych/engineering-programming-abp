using Abp.Application.Services.Dto;

namespace LAB.Categories.Dto
{
    public class PagedCategoryResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

