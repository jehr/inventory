using Application.Interfaces.Mark;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Mark
{
    public class MarkService : IMarkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MarkService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Domain.Models.Configurations.Mark>> GetAll()
        {
           return await _unitOfWork.mark.Get().ToListAsync();
        }
    }
}
