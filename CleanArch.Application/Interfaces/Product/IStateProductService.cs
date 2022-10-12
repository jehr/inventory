using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Product
{
    public interface IStateProductService
    {
        Task<List<Domain.Models.Product.StateProduct>> GetAll();
    }
}
