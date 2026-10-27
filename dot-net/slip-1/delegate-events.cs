using System;

delegate void NotifyHandler(string message);

class Notification
{
    public event NotifyHandler NotificationSent;

    public void SendNotification()
    {
        Console.WriteLine("Sending notification...");

        NotificationSent?.Invoke(
            "Notification sent successfully."
        );
    }
}

class Program
{
    static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        Notification n = new Notification();

        n.NotificationSent += DisplayMessage;

        n.SendNotification();
    }
}