using Application.DTOs.Product;
using Application.Interfaces.Product;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products.Queries
{
    public class GetTypeProductsQuery : IRequest<List<TypeProductDto>>
    {
    }

    public class GetTypeProductsQueryHandler : IRequestHandler<GetTypeProductsQuery, List<TypeProductDto>>
    {
        private readonly IMapper _mapper;
        private readonly ITypeProductService _typeProductService;


        public GetTypeProductsQueryHandler(IMapper mapper, ITypeProductService typeProductService)
        {
            _mapper = mapper;
            _typeProductService = typeProductService;
        }

        public async Task<List<TypeProductDto>> Handle(GetTypeProductsQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<TypeProductDto>>(await _typeProductService.GetAll());
        }

    }
}
