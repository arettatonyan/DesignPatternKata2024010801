using KataPattern2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern2.Notifications
{
    internal class ChainNotificationDecorator : INotification
    {
        private readonly INotification deceoraratedNotification;
        private readonly INotification nextNotification;

        public ChainNotificationDecorator(INotification deceoraratedNotification, INotification nextNotification)
        {
            this.deceoraratedNotification = deceoraratedNotification;
            this.nextNotification = nextNotification;
        }


        public bool Send(MessageModel message)
        {
            var result = deceoraratedNotification.Send(message);

            if (!result) 
            {
                Console.WriteLine("Yollanamadı");
                return nextNotification.Send(message);
            }

            return result;

        }
    }
}
