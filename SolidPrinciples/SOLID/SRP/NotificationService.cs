namespace SolidPrinciples.SOLID.SRP{
    public class NotificationService
    {
        public enum enNotificationType { Email, SMS, FAX };
        public void SendNotification(string to, string message, enNotificationType NotificationType)
        {
            if (NotificationType == enNotificationType.Email)
            {
                EmailService.SendEmail(to, message);
            }
            else if (NotificationType == enNotificationType.SMS)
            {
                SMSService.SendSMS(to, message);
            }
            else if (NotificationType == enNotificationType.FAX)
            {
                FaxService.SendFax(to, message);
            }
        }
    }
    public class EmailService
    {
        public static void SendEmail(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to} : {message}");
        }
    }
    public class SMSService
    {
        public static void SendSMS(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to} : {message}");
        }
    }
    public class FaxService
    {
        public static void SendFax(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to} : {message}");
        }
    }
}