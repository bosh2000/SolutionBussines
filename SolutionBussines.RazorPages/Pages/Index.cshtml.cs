using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SolutionBussines.DBRepository.Interfaces;
using SolutionBussines.Models.Db;
using SolutionBussines.Models.ViewModel;

namespace SolutionBussines.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDbRepository _repository;

        public IndexModel(ILogger<IndexModel> logger, IDbRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public SelectList ProviderList => new SelectList(_repository.Provider.ToListAsync().Result, nameof(Provider.Id), nameof(Provider.Name));
        public int SelectedProvider { get; set; }
        public NewOrderDto ValOrder { get; set; } = new();
        public DateTime DateEnd { get; set; } = DateTime.Now;
        public DateTime DateStart { get; set; } = DateTime.Now.AddDays(-30);

        public async void OnGet()
        {
        }

        public async Task<IActionResult> OnGetDeleteOrder(int? orderId)
        {
            if (orderId is not null)
            {
                Order deletedOrder = await _repository.Order.FirstOfDefaultAsync(x => x.Id == orderId);
                await _repository.Order.DeleteAsync(deletedOrder);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostCreateNewOrder(NewOrderDto newOrder)
        {
            if (newOrder is not null)
            {
                await _repository.Order.Create(newOrder);
            }
            return Page();
        }
    }
}