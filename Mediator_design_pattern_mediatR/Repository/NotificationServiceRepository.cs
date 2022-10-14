using Mediator_design_pattern_mediatR.Model;
using Mediator_design_pattern_mediatR.Repository.IRepository;

namespace Mediator_design_pattern_mediatR.Repository
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
