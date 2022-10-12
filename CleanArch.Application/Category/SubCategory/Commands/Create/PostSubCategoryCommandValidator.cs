using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Category.SubCategory.Commands.Create
{
    public class PostSubCategoryCommandValidator : AbstractValidator<PostSubCategoryCommand>
    {
        public PostSubCategoryCommandValidator()
        {
            RuleFor(x => x.CategoryId)
                         .NotEmpty()
                         .WithMessage("La categoria no puede estar vacío");
        }
    }
}
