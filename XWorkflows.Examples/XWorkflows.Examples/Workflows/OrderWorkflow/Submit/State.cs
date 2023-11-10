using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Submit;

public class SubmitOrderState : OrderWorkflowState
{
    public override string Identifier => $"{nameof(Base.OrderWorkflow)}.{nameof(SubmitOrderState)}";

    public async override Task<OrderEntityState> GetState(OrderEntity data)
    {
        return OrderEntityState.Submitted;
    }

}
