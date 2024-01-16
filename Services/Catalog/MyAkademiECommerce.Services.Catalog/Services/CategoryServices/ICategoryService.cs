using MyAkademiECommerce.Services.Catalog.Dtos.CategoryDtos;

namespace MyAkademiECommerce.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<ResultCategoryDto> GetCategoryByIdAsync(string id);
    }   
}
