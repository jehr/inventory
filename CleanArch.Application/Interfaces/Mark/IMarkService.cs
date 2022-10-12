using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Mark
{
    public interface IMarkService
    {
        Task<List<Domain.Models.Configurations.Mark>> GetAll();
    }
}
