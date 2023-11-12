using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Repositories;

namespace XWorkflows.Examples.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repository;

    public TaskService(ITaskRepository repository)
    {
        _repository = repository;
    }
    public async Task<string> Create(TaskEntity entity)
    {
        var id = Guid.NewGuid().ToString();
        await _repository.Save(id, entity);
        return id;
    }

    public async Task<TaskEntity> Get(string id)
    {
        return await _repository.Get(id);
    }

    public async Task<List<TaskEntity>> List()
    {
        return await _repository.List();
    }

    public async Task Save(TaskEntity entity, string id)
    {
        await _repository.Save(id, entity);
    }
}