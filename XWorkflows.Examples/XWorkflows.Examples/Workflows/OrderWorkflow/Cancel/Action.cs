using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Cancel;

public class CancelOrderAction : OrderWorkflowAction<CancelOrderEvent, CancelOrderState, OrderEntity, CancelOrderActionRequest, bool>
{
    private readonly IOrderService _orderService;

    public CancelOrderAction(CancelOrderState state, CancelOrderEvent e,IOrderService orderService) : base(state, e)
    {
        _orderService = orderService;
    }

    public async override Task<(WorkflowActionResult<bool>, OrderEntity)> Execute(OrderEntity data, CancelOrderActionRequest p, CancellationToken cancelationToken)
    {
        await base.Execute(data, p, cancelationToken);
        await _orderService.Save(data,p.Id);
        return new (
            WorkflowActionResult<bool>.Success(true),
            data
        );
    }
}
