using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Repositories;

public interface ITaskRepository
{
    Task<TaskEntity> Get(string id);
    Task<List<TaskEntity>> List();
    Task Save(string id, TaskEntity entity);
}