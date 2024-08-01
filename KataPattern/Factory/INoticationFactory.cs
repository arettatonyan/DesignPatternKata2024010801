using KataPattern.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern.Factory
{
    internal interface INotificationFactory
    {
        IList<INotification> GetNotifications();
    }
}
