using Mediator_design_pattern_mediatR.Repository.IRepository;
using MediatR;

namespace Mediator_design_pattern_mediatR.Mediator
{
    public class ShoppingBasketRequestHandler : RequestHandler<ShoppingBasketRequest>
    {

        private readonly IProductServiceRepository _productServiceRepository;
        private readonly IShoppingServiceRepository _shoppingServiceRepository;
        private readonly INotificationServiceRepository _notificationServiceRepository;

        public ShoppingBasketRequestHandler(IProductServiceRepository productServiceRepository, IShoppingServiceRepository shoppingServiceRepository, INotificationServiceRepository notificationServiceRepository)
        {
            _productServiceRepository = productServiceRepository;
            _shoppingServiceRepository = shoppingServiceRepository;
            _notificationServiceRepository = notificationServiceRepository;
        }


        protected override void Handle(ShoppingBasketRequest request)
        {
            // Fetch product from database
            var product = _productServiceRepository.GetProduct(request.ProductId);

            // Add product to basket
            _shoppingServiceRepository.AddToBasket(product);

            // Send notification to user
            _notificationServiceRepository.SendNotification(product);
        }
    }
}
