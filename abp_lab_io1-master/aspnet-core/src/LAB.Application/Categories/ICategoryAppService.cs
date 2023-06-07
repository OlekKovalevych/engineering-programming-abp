using Abp.Application.Services;
using LAB.Categories.Dto;

namespace LAB.Categories
{
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, long, PagedCategoryResultRequestDto, CategoryDto, CategoryDto>
    {

    }
}
