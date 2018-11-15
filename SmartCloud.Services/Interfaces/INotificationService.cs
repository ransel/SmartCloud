using SmartCloud.Domain.Notifications;

namespace SmartCloud.Services.Interfaces
{
    public interface INotificationService
    {
        void Send(string to, INotification notification);
    }
}