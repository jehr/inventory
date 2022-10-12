using Application.DTOs.Configurations;
using Application.Interfaces.Category;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Category.Category.Commands.Create
{
    public class PostCategoryCommand : IRequest<CategoryDto>
    {
        public string Name { get; set; }
    }

    public class PostCategoryCommanddHandler : IRequestHandler<PostCategoryCommand, CategoryDto>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public PostCategoryCommanddHandler(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }
        public async Task<CategoryDto> Handle(PostCategoryCommand request, CancellationToken cancellationToken)
        {
            Domain.Models.Configurations.Category category = _mapper.Map<Domain.Models.Configurations.Category>(request);

            return _mapper.Map<CategoryDto>(await _categoryService.Post(category, cancellationToken));
        }
    }
}
