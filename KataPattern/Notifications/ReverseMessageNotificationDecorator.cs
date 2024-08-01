using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern.Notifications
{
    internal class ReverseMessageNotificationDecorator : INotification
    {
        private readonly INotification decoratedNotificartion;

        public ReverseMessageNotificationDecorator(INotification decoratedNotificartion)
        {
            this.decoratedNotificartion = decoratedNotificartion;
        }


        public bool Send(string message)
        {
            string reverseMessage =  Reverse(message);

            return decoratedNotificartion.Send(reverseMessage);
        }


        private string Reverse(string message)
        {
            string str = message;
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            return reversedStr;
        }
    }
}
