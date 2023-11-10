using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Workflows.OrderWorkflow.Base;

public class OrderWorkflow : WorkflowBase<OrderWorkflow, OrderEntity, OrderEntityState>
{
    public OrderWorkflow(IEnumerable<IWorkflowOwner<OrderWorkflow>> actions,IServiceProvider provider) : base(actions,provider)
    {
    }
}