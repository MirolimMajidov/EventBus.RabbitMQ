namespace EventBus.RabbitMQ.Publishers;

/// <summary>
/// The base provider interface for implementing storing and reading events before publishing to the EventBus.
/// More information about the Inbox and Outbox pattern: https://en.wikipedia.org/wiki/Inbox_and_outbox_pattern
/// </summary>
/// <typeparam name="TOutboxEvent">The structure of sending an event type for storing and reading</typeparam>
public interface IOutboxEventProvider<TOutboxEvent> where TOutboxEvent : IOutboxEvent
{
}