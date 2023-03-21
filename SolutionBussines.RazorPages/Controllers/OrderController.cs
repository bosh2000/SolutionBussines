using Microsoft.AspNetCore.Mvc;
using SolutionBussines.DBRepository.Interfaces;
using SolutionBussines.Models.ViewModel;
using System.Text.Json;

namespace ASP.Controllers
{
    [Route("Api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IDbRepository _repository;

        public OrderController(IDbRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult<string>> GetOrderList()
        {
            DateTime dateStart;
            if (!DateTime.TryParse(Request.Form["dateStart"].FirstOrDefault(), out dateStart)) { dateStart = DateTime.MinValue; };
            DateTime dateEnd;
            if (!DateTime.TryParse(Request.Form["dateEnd"].FirstOrDefault(), out dateEnd)) { dateEnd = DateTime.MaxValue; };

            var request = new FullListRequest()
            {
                Draw = Request.Form["draw"].FirstOrDefault(),
                Start = Request.Form["start"].FirstOrDefault(),
                Length = Request.Form["length"].FirstOrDefault(),
                SortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][data]"].FirstOrDefault(),
                SortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault(),
                SearchValue = Request.Form["search[value]"].FirstOrDefault(),
                DateStart = dateStart,
                DateEnd = dateEnd
            };
            var data = await _repository.Order.ToList(request);
            var dataXLSX = data.Select(
                x => new OrderTableDto
                {
                    id = x.Id,
                    order_number = x.Number,
                    dateorder = x.Date.ToString("dd-MM-yyyy"),
                    provider = x.Provider.Name
                }).ToList();
            var jsonResult = new JsonResultRequest()
            {
                draw = request.Draw,
                recordsFiltered = request.RecordsTotal,
                recordsTotal = request.RecordsTotal,
                data = dataXLSX.Select(x => (object)x).ToList()
            };

            return Ok(JsonSerializer.Serialize(jsonResult));
        }
    }
}