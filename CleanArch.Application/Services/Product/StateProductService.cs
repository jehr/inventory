using Application.Interfaces.Product;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Product
{
    public class StateProductService : IStateProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StateProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<StateProduct>> GetAll()
        {
            return await _unitOfWork.stateProduct.Get().ToListAsync();
        }
    }
}
