using KataPattern2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern2.Notifications
{
    internal class CompositeNotification : INotification
    {
        private readonly IList<INotification> notifications;

        public CompositeNotification(IList<INotification> notifications)
        {
            this.notifications = notifications;
        }

        public bool Send(MessageModel message)
        {
            foreach (var notification in notifications)
            {
                notification.Send(message);
            }

            return true;
        }
    }
}
