namespace SolidPrinciples.SOLID.SRP
{
    public class NotificationService
    {
        public enum enNotificationType { Email, SMS, FAX };
        public void SendNotification(string to, string message, IService service)
        {
            service.Send(to, message);
        }
    }
    public interface IService
    {
        public void Send(string to, string message);
    }
    public class EmailService : IService
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to} : {message}");
        }
    }
    public class SMSService : IService
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to} : {message}");
        }
    }
    public class FaxService : IService
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to} : {message}");
        }
    }
}