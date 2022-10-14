using Mediator_design_pattern_mediatR.Model;

namespace Mediator_design_pattern_mediatR.Repository.IRepository
{
    public interface INotificationServiceRepository
    {
        void SendNotification(Product product);
    }
}
