using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Base;

public class OrderWorkflowAction<E,S,EP,AP,AR>: WorkflowAction<
    Base.OrderWorkflow,
    E,
    S,
    OrderEntity,
    OrderEntityState,
    EP,
    AP,
    AR
>
    where E:IWorkflowEvent
    where S:IWorkflowState<OrderEntity,OrderEntityState,Base.OrderWorkflow>
{
    public OrderWorkflowAction(S state, E e) : base(state, e)
    {
    }
}