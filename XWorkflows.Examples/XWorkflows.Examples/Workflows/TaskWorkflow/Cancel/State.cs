using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;

public class CancelTaskState : TaskWorkflowState
{
    public override string Identifier => $"{nameof(Base.TaskWorkflow)}.{nameof(CancelTaskState)}";
    
    public async override Task<TaskEntityState> GetState(TaskEntity data)
    {
        return TaskEntityState.Canceled;
    }
}