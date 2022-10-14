using AutoMapper;
using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Repository.IRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Mediator.Command
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {

        private readonly IProductRepository _productRespository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRespository, IMapper mapper)
        {
            _productRespository = productRespository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var createProduct = _mapper.Map<Product>(request._createProduct);

            return await _productRespository.CreateProductAsync(createProduct);
        }
    }
}
