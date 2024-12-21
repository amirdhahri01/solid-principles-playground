using SolidPrinciples.SOLID;

namespace SOLID
{

    public class Program
    {
        public static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();
            notificationService.SendNotification("Jhonazdaz", "Helo", NotificationService.enNotificationType.Email);
            notificationService.SendNotification("Jhonazdaz", "Helo", NotificationService.enNotificationType.SMS);
            notificationService.SendNotification("Jhonazdaz", "Helo", NotificationService.enNotificationType.FAX);
        }
    }
}