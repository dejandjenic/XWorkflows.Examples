using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Completed;

public class CompletedTaskState : TaskWorkflowState
{
    public override string Identifier => $"{nameof(TaskWorkflow.Base.TaskWorkflow)}.{nameof(CompletedTaskState)}";

    public async override Task<TaskEntityState> GetState(TaskEntity data)
    {
        return TaskEntityState.Completed;
    }

}
