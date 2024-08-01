﻿using KafkaPatterns.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern.Notifications.Interface
{
    internal class SmsNotification : INotification
    {
        public bool Send(string message)
        {
            Console.WriteLine("SMS: " + message);
            return true;
        }
    }
}
