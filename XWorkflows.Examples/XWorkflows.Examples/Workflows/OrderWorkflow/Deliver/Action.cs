using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Deliver;
public class DeliverOrderAction : OrderWorkflowAction<DeliverOrderEvent, DeliverOrderState, OrderEntity, DeliverOrderActionRequest, bool>
{
    private readonly IOrderService _orderService;

    public DeliverOrderAction(DeliverOrderState state, DeliverOrderEvent e,IOrderService orderService) : base(state, e)
    {
        _orderService = orderService;
    }

    public async override Task<(WorkflowActionResult<bool>, OrderEntity)> Execute(OrderEntity data, DeliverOrderActionRequest p, CancellationToken cancelationToken)
    {
        await base.Execute(data, p, cancelationToken);
        await _orderService.Save(data,p.Id);
        return new (
            WorkflowActionResult<bool>.Success(true),
            data
        );
    }
}
