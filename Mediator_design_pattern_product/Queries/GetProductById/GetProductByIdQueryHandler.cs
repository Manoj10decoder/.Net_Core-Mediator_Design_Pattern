using AutoMapper;
using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Model.Dto;
using Mediator_design_pattern_product.Repository.IRepository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {

        private readonly IProductRepository _productRespository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRespository, IMapper mapper)
        {
            _productRespository = productRespository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRespository.GetProductByIdAsync(request.Id);

            return _mapper.Map<ProductDto>(products);
        }
    }
}
