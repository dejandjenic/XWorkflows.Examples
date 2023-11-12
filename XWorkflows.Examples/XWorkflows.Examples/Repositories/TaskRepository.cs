using System.Text.Json;
using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Repositories;

public class TaskRepository : ITaskRepository
{
    public void EnsureDirectory(string path)
    {
        var dirPath = Path.GetDirectoryName(path);

        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);
    }
    public async Task<TaskEntity> Get(string id)
    {
        var path = Path.Combine("data","task", id + ".json");
        EnsureDirectory(path);

        if (!File.Exists(path))
            return null;
        
        using var fs= new FileStream(path, FileMode.Open);
        return await JsonSerializer.DeserializeAsync<TaskEntity>(fs);
    }

    public async Task<List<TaskEntity>> List()
    {
        var path =Path.Combine( "data","task");
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var result = new List<TaskEntity>();

        foreach (var file in Directory.GetFiles(path))
        {
            using var fs = new FileStream(file, FileMode.Open);
            var item = await JsonSerializer.DeserializeAsync<TaskEntity>(fs);
            result.Add(item);
        }

        return result;
    }

    public async Task Save(string id, TaskEntity entity)
    {
        var path = Path.Combine("data", "task", id + ".json");
        EnsureDirectory(path);

        using var fs = new FileStream(path, FileMode.CreateNew);
        await JsonSerializer.SerializeAsync(fs, entity, options: new JsonSerializerOptions()
        {
            WriteIndented = true
        });
}
}