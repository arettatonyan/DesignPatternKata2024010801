using KataPattern2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern2.Notifications
{
    internal class ReverseMessageNotificationDecorator : INotification
    {
        private readonly INotification decoratedNotificartion;

        public ReverseMessageNotificationDecorator(INotification decoratedNotificartion)
        {
            this.decoratedNotificartion = decoratedNotificartion;
        }


        public bool Send(MessageModel message)
        {
            string reverseMessage =  Reverse(message.Message);
            var newModel =  new MessageModel { Type = message.Type, Message = reverseMessage };

            return decoratedNotificartion.Send(newModel);
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
