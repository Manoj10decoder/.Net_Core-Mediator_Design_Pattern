using Mediator_design_pattern_Code_Imp.Repository.IRepository;

namespace Mediator_design_pattern_Code_Imp.Repository
{
    public class ShoppingMediatorRepository : IShoppingMediatorRepository
    {

        private readonly IProductServiceRepository _productServiceRepository;
        private readonly IShoppingServiceRepository _shoppingServiceRepository;
        private readonly INotificationServiceRepository _notificationServiceRepository;

        public ShoppingMediatorRepository(IProductServiceRepository productServiceRepository, IShoppingServiceRepository shoppingServiceRepository, INotificationServiceRepository notificationServiceRepository)
        {
            _productServiceRepository = productServiceRepository;
            _shoppingServiceRepository = shoppingServiceRepository;
            _notificationServiceRepository = notificationServiceRepository;
        }

        public void Handle(int id)
        {
            // Fetch product from database
            var product = _productServiceRepository.GetProduct(id);

            // Add product to basket
            _shoppingServiceRepository.AddToBasket(product);

            // Send notification to user
            _notificationServiceRepository.SendNotification(product);
        }
    }
}
