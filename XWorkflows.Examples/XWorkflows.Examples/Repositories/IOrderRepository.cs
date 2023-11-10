using XWorkflows.Examples.Entities;

namespace XWorkflows.Examples.Repositories;

public interface IOrderRepository
{
    Task<OrderEntity> Get(string id);
    Task<List<OrderEntity>> List();
    Task Save(string id, OrderEntity entity);
}