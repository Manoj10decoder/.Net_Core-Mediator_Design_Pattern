using AutoMapper;
using Mediator_design_pattern_product.Model;
using Mediator_design_pattern_product.Repository.IRepository;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Mediator.Command
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _productRespository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IProductRepository productRespository, IMapper mapper)
        {
            _productRespository = productRespository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.productDto);

            return await _productRespository.DeleteProductAsync(product);
        }
    }
}
