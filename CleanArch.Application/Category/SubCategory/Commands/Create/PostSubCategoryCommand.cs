using Application.DTOs.Configurations;
using Application.Interfaces.Category;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Category.SubCategory.Commands.Create
{
    public class PostSubCategoryCommand : IRequest<SubCategoryDto>
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public bool Active { get; set; }
    }

    public class SubCategoryCommandHandler : IRequestHandler<PostSubCategoryCommand, SubCategoryDto>
    {
        private readonly IMapper _mapper;
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryCommandHandler(IMapper mapper, ISubCategoryService subCategoryService)
        {
            _mapper = mapper;
            _subCategoryService = subCategoryService;
        }
        public async Task<SubCategoryDto> Handle(PostSubCategoryCommand request, CancellationToken cancellationToken)
        {
            Domain.Models.Configurations.SubCategory category = _mapper.Map<Domain.Models.Configurations.SubCategory>(request);

            return _mapper.Map<SubCategoryDto>(await _subCategoryService.Post(category, cancellationToken));
        }
    }
}
