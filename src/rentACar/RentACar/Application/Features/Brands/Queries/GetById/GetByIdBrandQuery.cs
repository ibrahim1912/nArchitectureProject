using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetById;

public class GetByIdBrandQuery : IRequest<GetByIdBrandResponse>
{
    public Guid Id { get; set; }

    public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandResponse>
    {

        private readonly IBrandRepository _brandResponse;
        private readonly IMapper _mapper;

        public GetByIdBrandQueryHandler(IBrandRepository brandResponse, IMapper mapper)
        {
            _brandResponse = brandResponse;
            _mapper = mapper;
        }

        public async Task<GetByIdBrandResponse> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandResponse.GetAsync(
                predicate: b => b.Id == request.Id,
                cancellationToken: cancellationToken
                );

            GetByIdBrandResponse response = _mapper.Map<GetByIdBrandResponse>(brand);

            return response;
        }
    }

}
