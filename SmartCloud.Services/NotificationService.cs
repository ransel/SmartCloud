using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using SmartCloud.Domain.Notifications;
using SmartCloud.Domain.Settings;
using SmartCloud.Services.Interfaces;
using Attachment = System.Net.Mail.Attachment;

namespace SmartCloud.Services
{
    public class NotificationService : INotificationService
    {
        private readonly string _fromEmail;
        private readonly string _smtpServerName;
        private readonly int _smtpPort;
        private readonly string _smtpClientPassword;
        private readonly ILoggingService _loggingService;

        public NotificationService(IOptions<NotificationSettings> notificationSettings, ILoggingService loggingService)
        {
            _fromEmail = notificationSettings.Value.From;
            _smtpServerName = notificationSettings.Value.SmtpServer;
            _smtpPort = int.Parse(notificationSettings.Value.SmtpPort);
            _smtpClientPassword = notificationSettings.Value.SmtpClientPassword;
            _loggingService = loggingService;
        }

        public void Send(string to, INotification notification)
        {
            var client = new SmtpClient
            {
                Host = _smtpServerName,
                Port = _smtpPort,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_fromEmail, _smtpClientPassword)
            };
            var msg = new MailMessage(_fromEmail, to, notification.Subject, notification.Body) { IsBodyHtml = true };
            if (notification.Attachments != null && notification.Attachments.Any())
            {
                foreach (var attachment in notification.Attachments)
                {
                    msg.Attachments.Add(new Attachment(attachment.Content, attachment.Name));
                }
            }
            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                _loggingService.LogCritical(string.Format("Exception sending notification email to {0} with message {1}", to, ex.Message));
            }
        }
    }
}