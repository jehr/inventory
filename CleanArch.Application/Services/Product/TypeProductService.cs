using Application.Interfaces.Product;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Product
{
    public class TypeProductService : ITypeProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TypeProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Domain.Models.Product.TypeProduct>> GetAll()
        {
            return await _unitOfWork.typeProduct.Get().ToListAsync();
        }
    }
}
