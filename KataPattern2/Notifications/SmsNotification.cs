using KataPattern2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern2.Notifications
{
    internal class SmsNotification : INotification
    {
        public bool Send(MessageModel message)
        {
            Console.WriteLine("SMS: " + message.Message);
            return true;
        }
    }
}
