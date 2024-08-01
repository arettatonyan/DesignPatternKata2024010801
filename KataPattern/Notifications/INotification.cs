namespace KataPattern.Notifications;

public interface INotification
{
    bool Send(string message);

}