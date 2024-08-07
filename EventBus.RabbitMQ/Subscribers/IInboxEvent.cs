using EventBus.RabbitMQ.InboxAndOutbox;

namespace EventBus.RabbitMQ.Subscribers;

/// <summary>
/// The structure of subscribing event for storing and reading
/// </summary>
public interface IInboxEvent : IBaseEventBox
{
}