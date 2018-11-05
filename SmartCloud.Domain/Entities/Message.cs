using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Message
    {
        public Guid MessageId { get; set; }
        public Guid? NotificationId { get; set; }
        public int? MessageTypeId { get; set; }
        public string Payload { get; set; }
        public int? Severity { get; set; }
        public bool? Sent { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte[] CreateSystem { get; set; }

        public MessageType MessageType { get; set; }
        public Notification Notification { get; set; }
    }
}
