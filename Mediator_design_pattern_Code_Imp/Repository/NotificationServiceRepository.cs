using Mediator_design_pattern_Code_Imp.Model;
using Mediator_design_pattern_Code_Imp.Repository.IRepository;

namespace Mediator_design_pattern_Code_Imp.Repository
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
