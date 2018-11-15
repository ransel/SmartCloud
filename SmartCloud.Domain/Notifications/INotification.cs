using System.Collections.Generic;

namespace SmartCloud.Domain.Notifications
{
    public interface INotification
    {
        string Subject { get; set; }
        string Body { get; set; }
        IList<IAttachment> Attachments { get; set; }        
    }
}