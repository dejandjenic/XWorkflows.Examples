using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Base;

public class TaskWorkflow : WorkflowBase<TaskWorkflow, TaskEntity, TaskEntityState>
{
    public TaskWorkflow(IEnumerable<IWorkflowOwner<TaskWorkflow>> actions,IServiceProvider provider) : base(actions,provider)
    {
    }
}