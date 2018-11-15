using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Notification
    {
        public Notification()
        {
            Message = new HashSet<Message>();
        }

        public Guid NotificationId { get; set; }
        public int NotificationTypeId { get; set; }
        public Guid? UserId { get; set; }
        public bool? RequiresWorkFlow { get; set; }
        public bool? Sent { get; set; }
        public DateTime? SentTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public NotificationType NotificationType { get; set; }
        public User User { get; set; }
        public ICollection<Message> Message { get; set; }
    }
}
