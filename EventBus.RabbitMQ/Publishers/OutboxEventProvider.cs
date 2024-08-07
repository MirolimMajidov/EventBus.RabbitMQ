using EventBus.RabbitMQ.InboxAndOutbox;

namespace EventBus.RabbitMQ.Publishers;

internal class OutboxEventProvider : BaseEventProvider, IOutboxEventProvider<IOutboxEvent>
{
    public OutboxEventProvider() : base()
    {
    }
}