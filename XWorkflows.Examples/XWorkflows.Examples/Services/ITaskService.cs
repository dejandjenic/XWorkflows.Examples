using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Services;

public interface ITaskService
{
    Task<string> Create(TaskEntity entity);
    Task<TaskEntity> Get(string id);
    Task<List<TaskEntity>> List();
    Task Save(TaskEntity entity,string id);
}