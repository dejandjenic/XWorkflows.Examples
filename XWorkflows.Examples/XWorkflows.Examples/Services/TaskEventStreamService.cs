using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Services;

public interface ITaskEventStreamService
{
    Task Event(TaskEntity entity, TaskEventType type);

}
public class TaskEventStreamService:ITaskEventStreamService
{
    public async Task Event(TaskEntity entity,TaskEventType type)
    {
        // persist 
    }
    
}

public enum TaskEventType
{
    Created,
    InProgress,
    Canceled,
    Completed
}