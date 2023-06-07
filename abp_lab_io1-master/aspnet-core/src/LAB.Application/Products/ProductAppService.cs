using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LAB.Products.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LAB.Products
{

    public class ProductAppService : AsyncCrudAppService<Product, ProductDto, long, PagedProductResultRequestDto, ProductDto, ProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, long> repository) : base(repository)
        {
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<PagedResultDto<ProductDto>> GetAllAsync(PagedProductResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }
    }
}