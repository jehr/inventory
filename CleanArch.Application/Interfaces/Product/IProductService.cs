using Application.DTOs.Product;
using Application.Products.Command.Create;
using Domain.Models.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces.Product
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAll();
        Task<bool> Post(PostProductCommand product, CancellationToken cancellationToken);
    }
}
