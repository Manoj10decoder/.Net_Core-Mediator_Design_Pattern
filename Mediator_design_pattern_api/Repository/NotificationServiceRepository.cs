using Mediator_design_pattern_api.Models;
using Mediator_design_pattern_api.Repository.IRepository;

namespace Mediator_design_pattern_api.Repository
{
    public class NotificationServiceRepository : INotificationServiceRepository
    {
        public void SendNotification(Product product)
        {
            // implement the code to send an email notification
            // to customer with the product details
        }
    }
}
