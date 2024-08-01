using KataPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class NotificationFacade : INotificationFacade
    {
        public void SendMessage(string message)
        {
            INotification mailNotification = new MailNotification();
            INotification smsNotification = new SmsNotification();
            INotification pushNotification = new PushNotification();

            mailNotification.Send(message);
            smsNotification.Send(message);
            pushNotification.Send(message);
        }
    }
}
