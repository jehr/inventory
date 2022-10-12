using Application.DTOs.Configurations;
using Application.DTOs.Product;
using Application.Products.Command.Create;
using Application.ViewModel;
using AutoMapper;
using Domain.Models.Configurations;
using Domain.Models.Product;

namespace CleanArch.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<SubCategory, SubCategoryDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Mark, MarkDto>(); 

            CreateMap<StateProduct, StateProductDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<TypeProduct, TypeProductDto>();

            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductResponseViewModel>();
        }
    }
}