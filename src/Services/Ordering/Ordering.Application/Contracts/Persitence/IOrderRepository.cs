using Ordering.Domain.Entities;


namespace Ordering.Application.Contracts.Persitence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        public interface IOrderRepository : IAsyncRepository<Order>
        {
            Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
        }
    }
}
