using Abp.Application.Services;
using LAB.Products.Dto;

namespace LAB.Products
{
    public interface IProductAppService : IAsyncCrudAppService<ProductDto, long, PagedProductResultRequestDto, ProductDto, ProductDto>
    {

    }
}
