﻿using Microservice.Events.MessageSubscriber.Interfaces;
using Microservice.Events.MessageSubscriber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Events.Order.Application
{
    public class OrderProcessor : IMessageProcessor
    {
        public void Process(Message message)
        {
            var order = (Order)message.Data.DeSerializeFromJSON(typeof(Order));
            Logger.LogInfoWithColor($"Processing Order: {order.OrderNo} for {order.CustomerUserName}", ((order.OrderNo % 2 == 0)? ConsoleColor.DarkGreen:ConsoleColor.DarkCyan));
            System.Threading.Thread.Sleep(1000);
        }
    }
}
