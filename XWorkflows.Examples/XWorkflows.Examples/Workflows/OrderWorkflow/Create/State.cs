using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.OrderWorkflow.Base;
using XWorkflows.Examples.Workflows.OrderWorkflow.Cancel;
using XWorkflows.Examples.Workflows.OrderWorkflow.Submit;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Create;

public class CreateOrderState : OrderWorkflowState
{
    public override string Identifier => $"{nameof(Base.OrderWorkflow)}.{nameof(CreateOrderState)}";

    public async override Task<OrderEntityState> GetState(OrderEntity data)
    {
        return OrderEntityState.Created;
    }

    public override IEnumerable<Type> AllowedTransitions()
    {
        return new List<Type>()
        {
            typeof(SubmitOrderAction),
            typeof(CancelOrderAction)
        };
    }
}