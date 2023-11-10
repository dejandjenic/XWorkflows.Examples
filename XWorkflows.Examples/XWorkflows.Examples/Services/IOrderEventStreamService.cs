using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Services;

public interface IOrderEventStreamService
{
    Task Event(OrderEntity entity,EventType type);
}