using EventBus.RabbitMQ.InboxAndOutbox;

namespace EventBus.RabbitMQ.Subscribers;

internal class InboxEventProvider : BaseEventProvider, IInboxEventProvider<IInboxEvent>
{
    public InboxEventProvider() : base()
    {
    }
}