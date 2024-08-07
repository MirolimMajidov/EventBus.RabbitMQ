namespace EventBus.RabbitMQ.InboxAndOutbox
{
    /// <summary>
    /// Represents an event type for storing and reading.
    /// </summary>
    public interface IBaseEventBox
    {
        /// <summary>
        /// Gets or sets the ID of the record.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets type of message. It can be Outbox or Inbox
        /// </summary>
        public string Channel { get; }

        /// <summary>
        /// Gets or sets the name of the class/event type. Ex: UserCreated, PaymentCompleted
        /// </summary>
        string EventPath { get; init; }

        /// <summary>
        /// Gets or sets the payload of the event in JSON format.
        /// </summary>
        string Payload { get; init; }

        /// <summary>
        /// Gets or sets the header data of the event in JSON format.
        /// </summary>
        string Headers { get; init; }

        /// <summary>
        /// Gets the creation time of the event.
        /// </summary>
        DateTimeOffset CreatedAt { get; }

        /// <summary>
        /// Gets the count of attempts to process the event.
        /// </summary>
        int TryCount { get; set; }

        /// <summary>
        /// Gets the count of attempts to process the event.
        /// </summary>
        public DateTimeOffset TryAfterAt { get; set; }

        /// <summary>
        /// Gets or sets the status of the event. When 0, the event is not sent/handled; when 1, the event is sent/handled.
        /// </summary>
        bool Processed { get; set; }
    }
}