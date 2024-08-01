// See https://aka.ms/new-console-template for more information


using Facade;
using KataPattern.Factory;
using KataPattern.Notifications;

string mesasage = "Kafka Sorunu";

new NotificationFacade(new NotificationFactory()).SendMessage(mesasage);


