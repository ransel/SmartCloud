using System.Collections.Generic;

namespace SmartCloud.Domain.Notifications
{
    public class Notification : INotification
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public IList<IAttachment> Attachments { get; set; }
    }
}