using Mediator_design_pattern_api.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator_design_pattern_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IProductServiceRepository _productServiceRepository;
        private readonly IShoppingServiceRepository _shoppingServiceRepository;
        private readonly INotificationServiceRepository _notificationServiceRepository;

        public ShoppingController(IProductServiceRepository productServiceRepository, IShoppingServiceRepository shoppingServiceRepository, INotificationServiceRepository notificationServiceRepository)
        {
            _productServiceRepository = productServiceRepository;
            _shoppingServiceRepository = shoppingServiceRepository;
            _notificationServiceRepository = notificationServiceRepository;
        }

        [HttpPost]
        public IActionResult AddToBasket(int id)
        {
            // Fetch product from database
            var product = _productServiceRepository.GetProduct(id);

            // Add product to basket
            _shoppingServiceRepository.AddToBasket(product);

            // Send notification to user
            _notificationServiceRepository.SendNotification(product);

            return Ok(product);
        }

    }
}
