﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal interface INotificationFacade
    {
        void SendMessage(string message);
    }
}