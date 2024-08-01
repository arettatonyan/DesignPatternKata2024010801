// See https://aka.ms/new-console-template for more information


using KataPattern.Notifications.Interface;

string mesasage = "Kafka Sorunu";



new MailNotification().Send(mesasage);
new SmsNotification().Send(mesasage);
new PushNotification().Send(mesasage);
