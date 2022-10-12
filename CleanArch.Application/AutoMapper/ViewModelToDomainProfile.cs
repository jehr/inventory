using Application.Category.Category.Commands.Create;
using Application.Category.SubCategory.Commands.Create;
using Application.Products.Command.Create;
using Application.ViewModel;
using AutoMapper;
using Domain.Models.Configurations;
using Domain.Models.Product;

namespace CleanArch.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<PostSubCategoryCommand, SubCategory>();
            CreateMap<PostCategoryCommand, Category>();
            CreateMap<PostProductCommand, Product>();
            CreateMap<ProductResponseViewModel, Product>();
            CreateMap<ProductResponseViewModel, Product>();
        }
    }
}

