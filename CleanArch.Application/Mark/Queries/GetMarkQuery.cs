using Application.DTOs.Configurations;
using Application.Interfaces.Mark;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Mark.Queries
{
    public class GetMarkQuery : IRequest<List<MarkDto>>
    {
    }

    public class GetMarkQueryHandler : IRequestHandler<GetMarkQuery, List<MarkDto>>
    {
        private readonly IMapper _mapper;
        private readonly IMarkService _markService;


        public GetMarkQueryHandler(IMapper mapper, IMarkService markService)
        {
            _mapper = mapper;
            _markService = markService;
        }

        public async Task<List<MarkDto>> Handle(GetMarkQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<MarkDto>>(await _markService.GetAll());
        }

    }
}
