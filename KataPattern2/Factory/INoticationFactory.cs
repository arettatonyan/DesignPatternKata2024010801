using KataPattern2.Model;
using KataPattern2.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern2.Factory
{
    internal interface INotificationFactory
    {
        IDictionary<MessageType, INotification> GetNotifications();
    }
}
