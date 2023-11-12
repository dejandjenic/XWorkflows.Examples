using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Base;

public class TaskWorkflowAction<E,S,EP,AP,AR>: WorkflowAction<
    TaskWorkflow,
    E,
    S,
    TaskEntity,
    TaskEntityState,
    EP,
    AP,
    AR
>
    where E:IWorkflowEvent
    where S:IWorkflowState<TaskEntity,TaskEntityState,TaskWorkflow>
{
    public TaskWorkflowAction(S state, E e) : base(state, e)
    {
    }
}