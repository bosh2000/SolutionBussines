using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SolutionBussines.DBRepository.Interfaces;
using SolutionBussines.Models.Db;
using SolutionBussines.Models.ViewModel;

namespace SolutionBussines.RazorPages.Pages
{
    public class DetailModel : PageModel
    {
        private readonly IDbRepository _repository;
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public List<OrderItem> OrderItemList { get; set; }
        public NewOrderItemDto NewOrderItem { get; set; } = new();
        public EditOrderItemDto EditItem { get; set; } = new();

        public DetailModel(IDbRepository repository)
        {
            _repository = repository;
        }

        public async Task OnGet(int OrderId)
        {
            Order = await _repository.Order.GetOrderById(OrderId);
            OrderItemList = await _repository.OrderItem.GetItemsByOrderId(Order.Id);
        }

        public async Task<IActionResult> OnPostAddItem(NewOrderItemDto newItem, int OrderId)
        {
            if (newItem is not null)
            {
                await _repository.OrderItem.AddNewItemToOrder(newItem, OrderId);
            }
            return RedirectToPage("./Detail", new { orderId = OrderId });
        }

        public async Task<IActionResult> OnGetOrderItemIdAsync(int orderItemId, int orderId)
        {
            EditItem = await _repository.OrderItem.GetItemEditModel(orderItemId);

            return Partial("_Edit", EditItem);
        }

        public async Task<IActionResult> OnPostSaveEditItem(EditOrderItemDto editOrderItem, int OrderId)

        {
            if (editOrderItem is not null)
            {
                await _repository.OrderItem.SaveNewItem(editOrderItem);
            }

            return RedirectToPage("./Detail", new { orderId = OrderId });
        }

        public async Task<IActionResult> OnGetDeleteOrderItem(int OrderId, int orderItemId)
        {
            await _repository.OrderItem.DeleteByIdAsync(orderItemId);
            return RedirectToPage("./Detail", new { orderId = OrderId });
        }
    }
}