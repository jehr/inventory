using Domain.Models.Configurations;
using Domain.Models.Product;
using System;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IIntRepository<Category> category { get; }
        IIntRepository<Mark> mark { get; }
        IIntRepository<SubCategory> subCategory { get; }
        IIntRepository<Product> product { get; }
        IIntRepository<StateProduct> stateProduct { get; }
        IIntRepository<TypeProduct> typeProduct { get; }

        void SaveChanges();
        Task SaveChangesAsync();

        string GetDbConnection();
    }
}
