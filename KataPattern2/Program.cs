// See https://aka.ms/new-console-template for more information


using Facade;
using KataPattern2.Factory;
using KataPattern2.Model;
using KataPattern2.Notifications;

string mesasage = "Kafka Sorunu";

new NotificationFacade(new NotificationFactory()).SendMessage(MessageType.SMS , mesasage);


