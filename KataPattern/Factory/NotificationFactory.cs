using KataPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern.Factory
{
    internal class NotificationFactory : INotificationFactory
    {
        private readonly IList<INotification> notificationList;

        public NotificationFactory()
        {
            notificationList = new List<INotification>();
            notificationList.Add(new MailNotification());
            notificationList.Add(new ReverseMessageNotificationDecorator(new SmsNotification()));
            notificationList.Add(new SmsNotification());
            notificationList.Add(new PushNotification());
        }

        public IList<INotification> GetNotifications()
        {
            return notificationList;
        }
    }
}
