using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Submit;

public class SubmitOrderEvent : OrderWorkflowEvent<OrderEntity>
{
    private readonly IOrderEventStreamService _stream;

    public SubmitOrderEvent(IOrderEventStreamService stream)
    {
        _stream = stream;
    }

    public async override Task Execute(OrderEntity data, CancellationToken cancelationToken)
    {
        await _stream.Event(data,EventType.Submitted);
    }
}
