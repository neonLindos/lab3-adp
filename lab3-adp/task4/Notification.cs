using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_adp.task4
{
    
    public class Notification : INotification
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        public Notification(string name, string text, string email)
        {
            Name = name;
            Text = text;
            Email = email;
        }
    }

    public interface INotification
    {
        string Name { get; set; }
        string Text { get; set; }
        string Email { get; set; }
    }

    public interface INotificationService
    {
        void Send(INotification notification);
    }

}
