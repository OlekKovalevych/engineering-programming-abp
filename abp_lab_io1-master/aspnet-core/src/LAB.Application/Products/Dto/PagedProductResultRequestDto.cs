using Abp.Application.Services.Dto;

namespace LAB.Products.Dto
{
    public class PagedProductResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

