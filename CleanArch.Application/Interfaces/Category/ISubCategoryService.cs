using Application.DTOs.Configurations;
using Domain.Models.Configurations;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces.Category
{
    public interface ISubCategoryService
    {
        Task<List<SubCategoryDto>> GetAll();
        Task<List<SubCategoryDto>> GetByIdCategory(int id);
        Task<SubCategory> Post(SubCategory subCategory, CancellationToken cancellationToken);

    }
}
