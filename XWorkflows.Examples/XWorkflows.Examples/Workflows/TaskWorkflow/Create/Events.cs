using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Services;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;
using XWorkflows.Examples.Workflows.TaskWorkflow.Base;

namespace XWorkflows.Examples.Workflows.TaskWorkflow.Create;

public class CreateTaskEvent : TaskWorkflowEvent<TaskEntity>
{
    private readonly ITaskEventStreamService _stream;

    public CreateTaskEvent(ITaskEventStreamService stream)
    {
        _stream = stream;
    }

    public async override Task Execute(TaskEntity data, CancellationToken cancelationToken)
    {
        await _stream.Event(data,TaskEventType.Created);
    }
}
