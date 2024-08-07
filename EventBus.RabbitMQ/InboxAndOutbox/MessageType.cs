namespace EventBus.RabbitMQ.InboxAndOutbox;

public struct MessageType
{
    /// <summary>
    /// Type name for storing all publishing event's structure
    /// </summary>
    public static string Inbox => "Inbox";

    /// <summary>
    /// Type name for storing all receiving event's structure
    /// </summary>
    public static string Outbox => "Outbox";
}