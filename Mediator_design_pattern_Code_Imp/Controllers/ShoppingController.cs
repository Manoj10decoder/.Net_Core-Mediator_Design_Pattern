using Mediator_design_pattern_Code_Imp.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator_design_pattern_Code_Imp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingMediatorRepository _shoppingMediatorRepository;

        public ShoppingController(IShoppingMediatorRepository shoppingMediatorRepository)
        {
            _shoppingMediatorRepository = shoppingMediatorRepository;
        }

        [HttpPost]
        public IActionResult AddToBasket(int id)
        {
            _shoppingMediatorRepository.Handle(id);


            return Ok();
        }
    }
}
