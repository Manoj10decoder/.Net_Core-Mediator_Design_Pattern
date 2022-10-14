using AutoMapper;
using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Repository.IRepository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Mediator.Command
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRespository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRespository, IMapper mapper)
        {
            _productRespository = productRespository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var updateProduct = _mapper.Map<Product>(request._updateProduct);

            return await _productRespository.UpdateProductAsync(updateProduct); ;
        }
    }
}
