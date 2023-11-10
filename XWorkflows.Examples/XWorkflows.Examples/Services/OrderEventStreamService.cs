using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Services;

public class OrderEventStreamService : IOrderEventStreamService
{
    public async Task Event(OrderEntity entity,EventType type)
    {
        // persist 
    }
}

public enum EventType
{
    Created,
    Submitted,
    Canceled
}