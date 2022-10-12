using Application.Interfaces.Category;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Domain.Models.Configurations.Category>> GetAll()
        {
            var data = await _unitOfWork.category.Get().ToListAsync();
            return data;
        }

        public async Task<Domain.Models.Configurations.Category> Post(Domain.Models.Configurations.Category category, CancellationToken cancellationToken)
        {
            return await _unitOfWork.category.Add(category);
        }
    }
}
