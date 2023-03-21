using SolutionBussines.Models.Db;
using SolutionBussines.Models.ViewModel;

namespace SolutionBussines.DBRepository.Interfaces
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
        Task<List<Order>> ToList(FullListRequest request);

        Task Create(NewOrderDto newOrder);

        Task<Order> GetOrderById(int orderId);
    }
}