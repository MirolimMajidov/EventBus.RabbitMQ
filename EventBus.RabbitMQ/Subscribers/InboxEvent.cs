using EventBus.RabbitMQ.InboxAndOutbox;

namespace EventBus.RabbitMQ.Subscribers;

internal class InboxEvent : IInboxEvent
{
    public Guid Id { get; } = Guid.NewGuid();

    public string EventType { get; init; }

    public string Payload { get; init; }

    public string Headers { get; init; }

    public DateTimeOffset CreatedAt { get; } = DateTimeOffset.Now;

    public string Type { get; } = MessageType.Inbox;

    public int TryCount { get; set; }

    public bool Processed { get; set; }
}