using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Deliver;

public class DeliverOrderState : OrderWorkflowState
{
    public override string Identifier => $"{nameof(Base.OrderWorkflow)}.{nameof(DeliverOrderState)}";

    public async override Task<OrderEntityState> GetState(OrderEntity data)
    {
        return OrderEntityState.Delivered;
    }

}
