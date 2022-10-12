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
    public class GetStateProductsQuery : IRequest<List<StateProductDto>>
    {
    }

    public class GetStateProductsQueryHandler : IRequestHandler<GetStateProductsQuery, List<StateProductDto>>
    {
        private readonly IMapper _mapper;
        private readonly IStateProductService _stateProductService;


        public GetStateProductsQueryHandler(IMapper mapper, IStateProductService stateProductService)
        {
            _mapper = mapper;
            _stateProductService = stateProductService;
        }

        public async Task<List<StateProductDto>> Handle(GetStateProductsQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<StateProductDto>>(await _stateProductService.GetAll());
        }

    }
}
