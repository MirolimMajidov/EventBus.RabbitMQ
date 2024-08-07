using EventBus.RabbitMQ.InboxAndOutbox;

namespace EventBus.RabbitMQ.Publishers;

internal class OutboxEvent : IOutboxEvent
{
    public Guid Id { get; } = Guid.NewGuid();

    public string EventType { get; init; }

    public string Payload { get; init; }

    public string Headers { get; init; }

    public DateTimeOffset CreatedAt { get; } = DateTimeOffset.Now;

    public string Type { get; } = MessageType.Outbox;

    public int TryCount { get; set; }

    public bool Processed { get; set; }
}