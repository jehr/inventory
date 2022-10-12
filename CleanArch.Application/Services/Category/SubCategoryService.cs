using Application.DTOs.Configurations;
using Application.Interfaces.Category;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Interfaces;
using Domain.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.Category
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SubCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<SubCategoryDto>> GetAll()
        {
            return await _unitOfWork.subCategory.Get().ProjectTo<SubCategoryDto>(_mapper.ConfigurationProvider).ToListAsync();
        }


        public async Task<List<SubCategoryDto>> GetByIdCategory(int id)
        {
            var categories = _unitOfWork.subCategory.Get().ProjectTo<SubCategoryDto>(_mapper.ConfigurationProvider);
            categories = categories.Where(x => x.CategoryId == id);

            return await categories.ToListAsync();
        }

        public async Task<SubCategory> Post(SubCategory subCategory, CancellationToken cancellationToken)
        {
            return await _unitOfWork.subCategory.Add(subCategory);
        }
    }
}
