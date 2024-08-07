using EventBus.RabbitMQ.InboxAndOutbox;

namespace EventBus.RabbitMQ.Publishers;

/// <summary>
/// The structure of publishing event for storing and reading
/// </summary>
public interface IOutboxEvent : IBaseEventBox
{
}