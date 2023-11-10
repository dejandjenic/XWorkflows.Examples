using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Create;

public class CreateOrderEvent : OrderWorkflowEvent<OrderEntity>
{
    private readonly IOrderEventStreamService _stream;

    public CreateOrderEvent(IOrderEventStreamService stream)
    {
        _stream = stream;
    }

    public async override Task Execute(OrderEntity data, CancellationToken cancelationToken)
    {
        await _stream.Event(data,EventType.Created);
    }
}
