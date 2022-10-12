using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Product
{
    public interface ITypeProductService
    {
        Task<List<Domain.Models.Product.TypeProduct>> GetAll();
    }
}
