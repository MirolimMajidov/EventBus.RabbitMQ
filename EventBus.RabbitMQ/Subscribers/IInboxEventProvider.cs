namespace EventBus.RabbitMQ.Subscribers;

/// <summary>
/// The base provider interface for implementing storing and reading events after receiving from the EventBus.
/// More information about the Inbox and Outbox pattern: https://en.wikipedia.org/wiki/Inbox_and_outbox_pattern
/// </summary>
/// <typeparam name="TInboxEvent">The structure of receiving an event type for storing and reading</typeparam>
public interface IInboxEventProvider<TInboxEvent> where TInboxEvent : IInboxEvent
{
    
}