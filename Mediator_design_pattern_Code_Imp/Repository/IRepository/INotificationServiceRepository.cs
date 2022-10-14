using Mediator_design_pattern_Code_Imp.Model;

namespace Mediator_design_pattern_Code_Imp.Repository.IRepository
{
    public interface INotificationServiceRepository
    {
        void SendNotification(Product product);
    }
}
