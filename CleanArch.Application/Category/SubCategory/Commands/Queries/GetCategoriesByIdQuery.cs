using Application.DTOs.Configurations;
using Application.Interfaces.Category;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Category.SubCategory.Commands.Queries
{
    public class GetCategoriesByIdQuery : IRequest<List<SubCategoryDto>>
    {
        public int Id { get; set; }

    }

    public class GetCategoriesByIdQueryHandler : IRequestHandler<GetCategoriesByIdQuery, List<SubCategoryDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISubCategoryService _subCategoryService;

        public GetCategoriesByIdQueryHandler(IMapper mapper, ISubCategoryService subCategoryService)
        {
            _mapper = mapper;
            _subCategoryService = subCategoryService;
        }

        public async Task<List<SubCategoryDto>> Handle(GetCategoriesByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<SubCategoryDto>>(await _subCategoryService.GetByIdCategory(request.Id));
        }
    }
}
