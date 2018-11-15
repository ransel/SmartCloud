using System.IO;

namespace SmartCloud.Domain.Notifications
{
    public interface IAttachment
    {
        string Name { get; set; }
        Stream Content { get; set; }        
    }
}