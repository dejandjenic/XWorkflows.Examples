using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.InProgress;

public class InProgressTaskEvent : TaskWorkflowEvent<TaskEntity>
{
    private readonly ITaskEventStreamService _stream;

    public InProgressTaskEvent(ITaskEventStreamService stream)
    {
        _stream = stream;
    }

    public async override Task Execute(TaskEntity data, CancellationToken cancelationToken)
    {
        await _stream.Event(data,TaskEventType.InProgress);
    }
}
