using Application.DTOs.Product;
using Application.Interfaces.Product;
using Application.Products.Command.Create;
using Application.ViewModel;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<ProductDto>> GetAll()
        {
            return await _unitOfWork.product.Get().ProjectTo<ProductDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<bool> Post(PostProductCommand product, CancellationToken cancellationToken)
        {

            return true;
        }
    }
}
