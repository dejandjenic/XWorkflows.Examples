using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;
using XWorkflows.Examples.Workflows.TaskWorkflow.InProgress;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Create;

public class CreateTaskState : TaskWorkflowState
{
    public override string Identifier => $"{nameof(TaskWorkflow.Base.TaskWorkflow)}.{nameof(CreateTaskState)}";

    public async override Task<TaskEntityState> GetState(TaskEntity data)
    {
        return TaskEntityState.Open;
    }

    public override IEnumerable<Type> AllowedTransitions()
    {
        return new List<Type>()
        {
            typeof(InProgressTaskAction),
            typeof(CancelTaskAction)
        };
    }
}