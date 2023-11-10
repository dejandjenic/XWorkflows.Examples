using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Model;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Create;

public class CreateOrderAction : OrderWorkflowAction<CreateOrderEvent, CreateOrderState, OrderEntity, CreateOrderActionRequest, IdObject>, IWorkflowStartAction
{
    private readonly IOrderService _orderService;

    public CreateOrderAction(CreateOrderState state, CreateOrderEvent e,IOrderService orderService) : base(state, e)
    {
        _orderService = orderService;
    }

    public async override Task<(WorkflowActionResult<IdObject>, OrderEntity)> Execute(OrderEntity data, CreateOrderActionRequest request, CancellationToken cancelationToken)
    {
        var order = new OrderEntity()
        {
            Description = request.Description,
            User = request.User
        };
        await base.Execute(order, request, cancelationToken);
        var id = await _orderService.Create(order);
        return new (
            WorkflowActionResult<IdObject>.Success(new IdObject(id)),
            order
        );
    }
}