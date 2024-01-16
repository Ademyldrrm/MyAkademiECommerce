using AutoMapper;
using MyAkademiECommerce.Services.Catalog.Dtos.CategoryDtos;
using MyAkademiECommerce.Services.Catalog.Models;

namespace MyAkademiECommerce.Services.Catalog.Mapping
{
    public class GeneralMappin:Profile
    {
        public GeneralMappin()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();

            CreateMap<Product,ResultCategoryDto>().ReverseMap();
            CreateMap<Product,CreateCategoryDto>().ReverseMap();
            CreateMap<Product,UpdateCategoryDto>().ReverseMap();
        }
    }
}
