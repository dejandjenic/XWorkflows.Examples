using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;
using XWorkflows.Examples.Workflows.TaskWorkflow.Completed;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.InProgress;

public class InProgressTaskState : TaskWorkflowState
{
    public override string Identifier => $"{nameof(TaskWorkflow.Base.TaskWorkflow)}.{nameof(InProgressTaskState)}";

    public async override Task<TaskEntityState> GetState(TaskEntity data)
    {
        return TaskEntityState.InProgress;
    }

    public override IEnumerable<Type> AllowedTransitions()
    {
        return new List<Type>()
        {
            typeof(CancelTaskAction),
            typeof(CompletedTaskAction)
        };
    }
}
