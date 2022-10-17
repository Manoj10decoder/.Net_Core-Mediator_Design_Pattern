using AutoMapper;
using Mediator_design_pattern_product.Repository.IRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Mediator.Query
{
    public class ProductExistsByIdQueryHandler : IRequestHandler<ProductExistsByIdQuery, bool>
    {
        private readonly IProductRepository _productRespository;
        private readonly IMapper _mapper;

        public ProductExistsByIdQueryHandler(IProductRepository productRespository, IMapper mapper)
        {
            _productRespository = productRespository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(ProductExistsByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productRespository.ProductExistsAsync(request.productId);
        }
    }
}
