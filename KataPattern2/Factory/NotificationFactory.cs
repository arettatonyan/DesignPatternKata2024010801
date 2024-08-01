using KataPattern2.Model;
using KataPattern2.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern2.Factory
{
    internal class NotificationFactory : INotificationFactory
    {
        private readonly IDictionary<MessageType, INotification> notificationDictionary;

        public NotificationFactory()
        {
            notificationDictionary = new Dictionary<MessageType, INotification>();
            notificationDictionary.Add(MessageType.Mail, new MultipleNotificationDecorator(new MailNotification(), 2));
            notificationDictionary.Add(MessageType.SMS, new MultipleNotificationDecorator(new SmsNotification(), 2));
            notificationDictionary.Add(MessageType.PUSH, new MultipleNotificationDecorator(new PushNotification(), 2));
        }

        public IDictionary<MessageType, INotification> GetNotifications()
        {
            return notificationDictionary;
        }
    }
}
