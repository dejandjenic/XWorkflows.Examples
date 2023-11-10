using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Submit;
public class SubmitOrderAction : OrderWorkflowAction<SubmitOrderEvent, SubmitOrderState, OrderEntity, SubmitOrderActionRequest, bool>
{
    private readonly IOrderService _orderService;

    public SubmitOrderAction(SubmitOrderState state, SubmitOrderEvent e,IOrderService orderService) : base(state, e)
    {
        _orderService = orderService;
    }

    public async override Task<(WorkflowActionResult<bool>, OrderEntity)> Execute(OrderEntity data, SubmitOrderActionRequest p, CancellationToken cancelationToken)
    {
        await base.Execute(data, p, cancelationToken);
        await _orderService.Save(data,p.Id);
        return new (
            WorkflowActionResult<bool>.Success(true),
            data
        );
    }
}
