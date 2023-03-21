using SolutionBussines.Models.Db;
using SolutionBussines.Models.ViewModel;

namespace SolutionBussines.DBRepository.Interfaces
{
    public interface IOrderItemRepository : IRepositoryBase<OrderItem>
    {
        Task<List<OrderItem>> GetItemsByOrderId(int orderId);

        Task AddNewItemToOrder(NewOrderItemDto newItem, int orderId);

        Task<EditOrderItemDto> GetItemEditModel(int itemId);

        Task SaveNewItem(EditOrderItemDto editOrderItem);

        Task DeleteByIdAsync(int orderItemId);
    }
}