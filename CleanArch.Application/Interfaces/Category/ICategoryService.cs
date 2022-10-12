using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces.Category
{
    public interface ICategoryService
    {
        Task<List<Domain.Models.Configurations.Category>> GetAll();
        Task<Domain.Models.Configurations.Category> Post(Domain.Models.Configurations.Category category, CancellationToken cancellationToken);
    }
}
