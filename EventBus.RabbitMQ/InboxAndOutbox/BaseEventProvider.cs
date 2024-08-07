namespace EventBus.RabbitMQ.InboxAndOutbox;

internal abstract class BaseEventProvider
{
    public BaseEventProvider()
    {
        
    }
    
    public void EnsureDatabaseAndTableCreated()
    {
        EnsureDatabaseCreated();
        EnsureTableCreated();
    }

    private void EnsureDatabaseCreated()
    {
    }

    private void EnsureTableCreated()
    {
    }
}