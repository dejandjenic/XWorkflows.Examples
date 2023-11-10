using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Cancel;

public class CancelOrderEvent : OrderWorkflowEvent<OrderEntity>
{
    private readonly IOrderEventStreamService _stream;

    public CancelOrderEvent(IOrderEventStreamService stream)
    {
        _stream = stream;
    }

    public async override Task Execute(OrderEntity data, CancellationToken cancelationToken)
    {
        await _stream.Event(data,EventType.Canceled);
    }
}
