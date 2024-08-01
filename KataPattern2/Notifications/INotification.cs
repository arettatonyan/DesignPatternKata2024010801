using KataPattern2.Model;

namespace KataPattern2.Notifications;

internal interface INotification
{
    bool Send(MessageModel message);

}