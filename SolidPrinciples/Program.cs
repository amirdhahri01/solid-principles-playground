using SolidPrinciples.SOLID.SRP;

namespace SOLID
{

    public class Program
    {
        public static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();
            notificationService.SendNotification("Jhonazdaz", "Helo", new EmailService());
            notificationService.SendNotification("Jhonazdaz", "Helo", new SMSService());
            notificationService.SendNotification("Jhonazdaz", "Helo", new FaxService());
        }
    }
}