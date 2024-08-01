using KataPattern2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern2.Notifications
{
    internal class MultipleNotificationDecorator : INotification
    {
        private readonly INotification decoratedNotification;
        private readonly int count;

        public MultipleNotificationDecorator(INotification decoratedNotification, int count)
        {
            this.decoratedNotification = decoratedNotification;
            this.count = count;
        }

        public bool Send(MessageModel message)
        {
            for (int i = 0; i < count; i++)
            {
                decoratedNotification.Send(message);
            }

            return true;
        }
    }
}
