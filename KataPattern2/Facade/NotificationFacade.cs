using KataPattern2.Factory;
using KataPattern2.Model;
using KataPattern2.Notifications;
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

        public void SendMessage(MessageType type, string message)
        {
            var model = new MessageModel
            {
                Type = type,
                Message = message
            };

            notificationFactory.GetNotifications()[type].Send(model);
        }
    }
}
