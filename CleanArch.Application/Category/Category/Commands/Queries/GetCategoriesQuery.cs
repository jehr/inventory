using Application.DTOs.Configurations;
using Application.Interfaces.Category;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Category.Category.Commands.Queries
{
    public class GetCategoriesQuery : IRequest<List<CategoryDto>>
    {
    }

    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<CategoryDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;


        public GetCategoriesQueryHandler(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public async Task<List<CategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<CategoryDto>>(await _categoryService.GetAll());
        }

    }
}
