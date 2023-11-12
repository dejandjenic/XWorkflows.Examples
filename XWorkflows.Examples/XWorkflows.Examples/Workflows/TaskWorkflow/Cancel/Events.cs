using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Cancel;

public class CancelTaskEvent : TaskWorkflowEvent<TaskEntity>
{
    private readonly ITaskEventStreamService _stream;

    public CancelTaskEvent(ITaskEventStreamService stream)
    {
        _stream = stream;
    }

    public async override Task Execute(TaskEntity data, CancellationToken cancelationToken)
    {
        await _stream.Event(data,TaskEventType.Canceled);
    }
}
