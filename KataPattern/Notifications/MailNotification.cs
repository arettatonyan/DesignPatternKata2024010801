﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPattern.Notifications
{
    internal class MailNotification : INotification
    {
        public bool Send(string message)
        {
            Console.WriteLine("Mail: " + message);
            return true;
        }
    }
}