using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Cancel;

public class CancelOrderState : OrderWorkflowState
{
    public override string Identifier => $"{nameof(Base.OrderWorkflow)}.{nameof(CancelOrderState)}";
    
    public async override Task<OrderEntityState> GetState(OrderEntity data)
    {
        return OrderEntityState.Canceled;
    }
}