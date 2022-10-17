using Mediator_design_pattern_product.Commands.CreateProduct;
using Mediator_design_pattern_product.Commands.DeleteProduct;
using Mediator_design_pattern_product.Commands.UpdateProduct;
using Mediator_design_pattern_product.Model.Dto;
using Mediator_design_pattern_product.Queries.GetAllProducts;
using Mediator_design_pattern_product.Queries.GetProductById;
using Mediator_design_pattern_product.Queries.ProductExistsById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mediator_design_pattern_product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet(Name = "GetProducts")]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{getProductId:int}", Name = "GetNationalPark")]
        public async Task<IActionResult> GetProductAsync(int getProductId)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(getProductId));

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost(Name = "createProduct")]
        public async Task<IActionResult> CreateProductAsync([FromBody] CreateProductDto createProduct)
        {
            if (createProduct == null)
            {
                return BadRequest(ModelState);
            }

            var createProductBool = await _mediator.Send(new CreateProductCommand(createProduct));

            if (!createProductBool)
            {
                ModelState.AddModelError("", "Something went wrong when saving the record");
                return StatusCode(500, ModelState);
            }

            return Created("", createProduct);
        }

        [HttpPatch("{updateProductId:int}", Name = "UpdateProduct")]
        public async Task<IActionResult> UpdateProductAsync(int updateProductId, [FromBody] UpdateProductDto updateProductDto)
        {
            if (updateProductDto == null || updateProductId != updateProductDto.Id)
            {
                return BadRequest(ModelState);  // model state typically contains all of the errors, if any are encountered next.
            }

            // check product
            if (!await _mediator.Send(new ProductExistsByIdQuery(updateProductId)))
            {
                return NotFound();
            }

            var updateProductBool = await _mediator.Send(new UpdateProductCommand(updateProductDto));

            if (!updateProductBool)
            {
                ModelState.AddModelError("", "Something went wrong when updating the record");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{deleteProductId:int}", Name = "DeleteProduct")]
        public async Task<IActionResult> DeleteProductAsync(int deleteProductId)
        {

            // check product
            if (!await _mediator.Send(new ProductExistsByIdQuery(deleteProductId)))
            {
                return NotFound();
            }

            // get national park
            var getProduct = await _mediator.Send(new GetProductByIdQuery(deleteProductId));

            if (!await _mediator.Send(new DeleteProductCommand(getProduct)))
            {
                ModelState.AddModelError("", "Something went wrong when deleting the record");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
    }
}
