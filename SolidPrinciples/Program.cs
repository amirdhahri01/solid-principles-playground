using SolidPrinciples.SOLID.LSP;
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
            Bird bird1 = new Eagle();
            bird1.Fly();
            bird1.Eat();
            Bird bird2 = new Ostrich();
            bird2.Eat();
            bird2.Fly();
        }
    }
}