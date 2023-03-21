using AutoMapper;
using SolutionBussines.DBRepository.Interfaces;
using SolutionBussines.Models.Db;
using SolutionBussines.Models.ViewModel;

namespace SolutionBussines.DBRepository.Impl.ItemsRepository
{
    public class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(SBDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<List<OrderItem>> GetItemsByOrderId(int orderId)
        {
            return await ConditionToListAsync(x => x.OrderId == orderId);
        }

        public async Task AddNewItemToOrder(NewOrderItemDto newItem, int orderId)
        {
            var order = _mapper.Map<OrderItem>(newItem);
            await CreateAsync(order);
        }

        public async Task<EditOrderItemDto> GetItemEditModel(int itemId)
        {
            OrderItem item = await FirstOfDefaultAsync(x => x.Id == itemId);
            var editItem = _mapper.Map<EditOrderItemDto>(item);
            return editItem;
        }

        public async Task SaveNewItem(EditOrderItemDto editOrderItem)
        {
            OrderItem item = await FirstOfDefaultAsync(x => x.Id == editOrderItem.Id);
            await UpdateAsync(_mapper.Map(editOrderItem, item));
        }

        public async Task DeleteByIdAsync(int orderItemId)
        {
            OrderItem item = await FirstOfDefaultAsync(x => x.Id == orderItemId);
            await DeleteAsync(item);
        }
    }
}