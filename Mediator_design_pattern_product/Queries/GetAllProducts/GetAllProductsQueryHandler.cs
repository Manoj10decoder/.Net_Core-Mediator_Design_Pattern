using AutoMapper;
using Mediator_design_pattern_product.Model.Dto;
using Mediator_design_pattern_product.Repository.IRepository;
using MediatR;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Queries.GetAllProducts
{
    /*
     * IRequestHandler<TRequest, TResponse> 
     * TResquest is the query type that the handler will handle.
     * TResponse is the response type that will be returned by the handler.
    */
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ICollection<ProductDto>>
    {
        private readonly IProductRepository _productRespository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IProductRepository productRespository, IMapper mapper)
        {
            _productRespository = productRespository;
            _mapper = mapper;
        }

        public async Task<ICollection<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRespository.GetAllProductsAsync();

            ICollection<ProductDto> productListDto = new List<ProductDto>();

            foreach (var obj in products)
            {
                productListDto.Add(_mapper.Map<ProductDto>(obj));
            }

            return productListDto;
        }
    }
}
