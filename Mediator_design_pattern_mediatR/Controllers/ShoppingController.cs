using Mediator_design_pattern_mediatR.Mediator;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator_design_pattern_mediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public ShoppingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult AddToBasket(int id)
        {
            _mediator.Send(new ShoppingBasketRequest() { ProductId = id });

            return Ok();
        }

    }
}
