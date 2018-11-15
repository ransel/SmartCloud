using System.IO;

namespace SmartCloud.Domain.Notifications
{
    public class Attachment : IAttachment
    {
        public string Name { get; set; }
        public Stream Content { get; set; }
    }
}