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
            notificationList.Add(new MultipleNotificationDecorator(new MailNotification(), 2));
            notificationList.Add(new MultipleNotificationDecorator(new ReverseMessageNotificationDecorator(new SmsNotification()), 3));
            notificationList.Add(new MultipleNotificationDecorator(new SmsNotification(), 4));
            notificationList.Add(new MultipleNotificationDecorator( new PushNotification(), 2));
        }

        public CompositeNotification GetNotifications()
        {
            return new CompositeNotification(notificationList);
        }
    }
}
