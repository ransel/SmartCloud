namespace SmartCloud.Domain.Settings
{
    public class NotificationSettings
    {
        public string From { get; set; }
        public string SmtpServer { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpClientPassword { get; set; }
    }
}