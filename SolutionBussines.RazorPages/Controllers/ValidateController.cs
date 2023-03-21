using Microsoft.AspNetCore.Mvc;
using SolutionBussines.DBRepository.Interfaces;
using SolutionBussines.Models.Db;

namespace SolutionBussines.RazorPages.Controllers
{
    public class ValidateController : Controller
    {
        private readonly IDbRepository _repository;

        public ValidateController(IDbRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> CheckNumber(int SelectedProvider, string Number)
        {
            Order Order = await _repository.Order.FirstOfDefaultAsync(x => x.ProviderId == SelectedProvider && x.Number == Number);
            return Order is not null ? Json("Номер заказа сушествует") : Json(true);
        }

        public async Task<IActionResult> CheckName(string Name, int OrderId)
        {
            Order order = await _repository.Order.FirstOfDefaultAsync(x => x.Id == OrderId);
            return order.Number == Name ? Json("Название совпадает с номером заказа") : Json(true);
        }
    }
}