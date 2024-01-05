using AutoMapper;
using MyAkademiECommerce.Services.Catalog.Dtos.CategoryDtos;
using MyAkademiECommerce.Services.Catalog.Models;

namespace MyAkademiECommerce.Services.Catalog.Mapping
{
    public class GeneralMappin:Profile
    {
        public GeneralMappin()
        {
            CreateMap<Category, ResultCategoryDto>();
            CreateMap<ResultCategoryDto, Category>();
            CreateMap<Category, CreateCategory>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();

            CreateMap<Product,ResultCategoryDto>().ReverseMap();
            CreateMap<Product,CreateCategory>().ReverseMap();
            CreateMap<Product,UpdateCategoryDto>().ReverseMap();
        }
    }
}
