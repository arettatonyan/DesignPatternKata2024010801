using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern.Notifications
{
    internal class CompositeNotification : INotification
    {
        private readonly IList<INotification> notifications;

        public CompositeNotification(IList<INotification> notifications)
        {
            this.notifications = notifications;
        }

        public bool Send(string message)
        {
            foreach (var notification in notifications)
            {
                notification.Send(message);
            }

            return true;
        }
    }
}
