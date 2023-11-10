using System.Text.Json;
using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Repositories;

public class OrderRepository : IOrderRepository
{
    public void EnsureDirectory(string path)
    {
        var dirPath = Path.GetDirectoryName(path);

        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);
    }
    public async Task<OrderEntity> Get(string id)
    {
        var path = Path.Combine("data", id + ".json");
        EnsureDirectory(path);

        if (!File.Exists(path))
            return null;
        
        using var fs= new FileStream(path, FileMode.Open);
        return await JsonSerializer.DeserializeAsync<OrderEntity>(fs);
    }

    public async Task<List<OrderEntity>> List()
    {
        var path = "data";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        var result = new List<OrderEntity>();

        foreach (var file in Directory.GetFiles(path))
        {
            using var fs = new FileStream(file, FileMode.Open);
            var item = await JsonSerializer.DeserializeAsync<OrderEntity>(fs);
            result.Add(item);
        }

        return result;
    }

    public async Task Save(string id, OrderEntity entity)
    {
        var path = Path.Combine("data", id + ".json");
        EnsureDirectory(path);
        
        using var fs = new FileStream(path, FileMode.OpenOrCreate);
        await JsonSerializer.SerializeAsync(fs, entity);
    }
}