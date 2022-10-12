using Application.DTOs.Configurations;
using Application.Interfaces.Category;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Category.SubCategory
{
    public class GetSubCategoriesQuery : IRequest<List<SubCategoryDto>>
    {
    }

    public class GetSubCategoriesQueryHandler : IRequestHandler<GetSubCategoriesQuery, List<SubCategoryDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISubCategoryService _subCategoryService;


        public GetSubCategoriesQueryHandler(IMapper mapper, ISubCategoryService subCategoryService)
        {
            _mapper = mapper;
            _subCategoryService = subCategoryService;
        }

        public async Task<List<SubCategoryDto>> Handle(GetSubCategoriesQuery request, CancellationToken cancellationToken)
        {
            return  _mapper.Map<List<SubCategoryDto>>(await _subCategoryService.GetAll());
        }
       
    }
}
