using XWorkflows.Examples.Entities;
using XWorkflows.Examples.Repositories;

namespace XWorkflows.Examples.Services;

public class OrderService: IOrderService
{
    private readonly IOrderRepository _repository;

    public OrderService(IOrderRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<string> Create(OrderEntity entity)
    {
        var id = Guid.NewGuid().ToString();
        await _repository.Save(id, entity);
        return id;
    }

    public async Task<OrderEntity> Get(string id)
    {
        return await _repository.Get(id);
    }

    public async Task<List<OrderEntity>> List()
    {
        return await _repository.List();
    }

    public async Task Save(OrderEntity entity,string id)
    {
        await _repository.Save(id, entity);
    }
}