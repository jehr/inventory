using Application.Common.BulkInserts;
using Application.Common.Interfaces;
using Application.Interfaces.Campus;
using Application.Interfaces.Category;
using Application.Interfaces.Inventory;
using Application.Interfaces.Mark;
using Application.Interfaces.Model;
using Application.Interfaces.Product;
using Application.Interfaces.Suppliers;
using Application.Services.Campus;
using Application.Services.Category;
using Application.Services.Inventory;
using Application.Services.Mark;
using Application.Services.Model;
using Application.Services.Product;
using Application.Services.Supplier;
using Domain.Interfaces;
using Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Ioc
{
    public static class ApplicationDependencycontainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
         
            services.AddScoped<IBulkInsert, BulkInsert>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();

            services.AddScoped<ISubCategoryService, SubCategoryService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IMarkService, MarkService>();
            services.AddScoped<ICampusService, CampusService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IModelService, ModelService>();

            services.AddScoped<IStateProductService, StateProductService>();
            services.AddScoped<ITypeProductService, TypeProductService>();
            services.AddScoped<IProductsBaseService, ProductsBaseService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IInventoryService, InventoryService>();

        }
    }
}
