namespace KafkaPatterns.Notifications;

public interface INotification
{
        bool Send(string message);

}