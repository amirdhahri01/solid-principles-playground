using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.SOLID
{
    public class NotificationService
    {
        public enum enNotificationType { Email, SMS, FAX };
        public void SendNotification(string to, string message, enNotificationType NotificationType)
        {
            if (NotificationType == enNotificationType.Email)
            {
                SendEmail(to, message);
            }
            else if (NotificationType == enNotificationType.SMS)
            {
                SendSMS(to, message);
            }
            else if (NotificationType == enNotificationType.FAX)
            {
                SendFax(to, message);
            }
        }
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to} : {message}");
        }
        public void SendSMS(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to} : {message}");
        }
        public void SendFax(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to} : {message}");
        }
    }
}