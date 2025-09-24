using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_adp.task4
{
    public class EmailService : INotificationService
    {
        public void Send(INotification notification)
        {
            Console.WriteLine($"Sending email to: {notification.Email}");
            Console.WriteLine($"Subject: {notification.Name}");
            Console.WriteLine($"Body: {notification.Text}");
        }

      
    }
}
