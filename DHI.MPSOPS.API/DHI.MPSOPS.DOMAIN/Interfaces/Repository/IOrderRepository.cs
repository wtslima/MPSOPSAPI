using System.Collections.Generic;
using System.Threading.Tasks;
using DHI.MPSOPS.DOMAIN.Model;

namespace DHI.MPSOPS.DOMAIN.Interfaces.Repository
{
    public interface IOrderRepository
    {
        Task<Order> GetOrders(string type);
        Task<Order> GetOrderById(int id);
        Task<IList<Order>> GetOrderByName(string name);
        Task<bool> DeleteOrder(int id);
        Task<bool> UpdateOrder(Order order);
        Task<bool> SaveOrder(Order order);
        dynamic GetPreviousOrder(int id);
        dynamic GetNextOrder(int id);
    }
}