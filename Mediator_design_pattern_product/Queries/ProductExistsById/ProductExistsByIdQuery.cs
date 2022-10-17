using MediatR;

namespace Mediator_design_pattern_product.Queries.ProductExistsById
{
    public class ProductExistsByIdQuery : IRequest<bool>
    {
        public int productId { get; set; }

        public ProductExistsByIdQuery(int productId)
        {
            this.productId = productId;
        }
    }
}
