using KataPattern.Factory;
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
        private readonly INotificationFactory notificationFactory;

        public NotificationFacade(INotificationFactory notificationFactory)
        {
            this.notificationFactory = notificationFactory;
        }

        public void SendMessage(string message)
        {
            var compositeNotification = new CompositeNotification(notificationFactory.GetNotifications());
            compositeNotification.Send(message);
        }
    }
}
