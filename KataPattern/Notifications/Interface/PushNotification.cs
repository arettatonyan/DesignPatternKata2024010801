using KafkaPatterns.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern.Notifications.Interface
{
    internal class PushNotification : INotification
    {
        public bool Send(string message)
        {
            Console.WriteLine("Push: " + message); 
            return true;
        }
    }
}
