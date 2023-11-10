using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Services;

public interface IOrderService
{
    Task<string> Create(OrderEntity entity);
    Task<OrderEntity> Get(string id);
    Task<List<OrderEntity>> List();
    Task Save(OrderEntity entity,string id);
}