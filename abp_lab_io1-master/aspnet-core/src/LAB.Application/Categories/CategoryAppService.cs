using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LAB.Categories.Dto;
using System.Threading.Tasks;

namespace LAB.Categories
{

    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, long, PagedCategoryResultRequestDto, CategoryDto, CategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, long> repository) : base(repository)
        {
        }

        public override Task<PagedResultDto<CategoryDto>> GetAllAsync(PagedCategoryResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }
    }
}