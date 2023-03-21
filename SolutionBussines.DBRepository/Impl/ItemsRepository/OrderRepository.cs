using AutoMapper;
using SolutionBussines.DBRepository.Interfaces;
using SolutionBussines.Models.Db;
using SolutionBussines.Models.ViewModel;
using System.Linq.Expressions;

namespace SolutionBussines.DBRepository.Impl.ItemsRepository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(SBDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Task<List<Order>> ToList(FullListRequest request)
        {
            return Task.Run(() =>
            {
                var customerData =
                  DBSet
                     .AsQueryable();

                var dataCus = customerData;
                
                if (!string.IsNullOrEmpty(request.SearchValue))
                {
                    var searchLissValue = request.SearchValue.Split(' ');
                    foreach (var search in searchLissValue)
                    {
                        var result = customerData.Where(
                            m => m.Date.ToString().Contains(search)
                              || m.Number.Contains(search)
                              || m.Provider.Name.Contains(search)
                              && m.Date >= request.DateStart 
                              && m.Date <= request.DateEnd
                        );
                        if (dataCus.Count() == 0)
                            dataCus = result;
                        else
                            dataCus = dataCus.Intersect(result);
                    }
                }
                if (!(string.IsNullOrEmpty(request.SortColumn) && string.IsNullOrEmpty(request.SortColumnDirection)))
                {
                    Expression<Func<Order, object>> exp = request.SortColumn switch
                    {
                        "id" => x => x.Id,
                        "order_number" => x => x.Number,
                        "dateorder" => x => x.Date,
                        "provider" => x => x.Provider
                    };
                    dataCus = dataCus.OrderBy(exp);
                    dataCus = request.SortColumnDirection == "asc" ? dataCus.OrderBy(exp) : dataCus.OrderByDescending(exp);
                }
                var dataList= dataCus.Where(x => x.Date >= request.DateStart && x.Date <= request.DateEnd).ToList();
                request.RecordsTotal = dataList.Count();
                dataList = dataList.Skip(request.Skip).ToList() ;
                if (request.Length != "-1")
                    dataList = dataList.Take(request.PageSize).ToList();
                return dataList;
            });
        }

        public async Task Create(NewOrderDto newOrder)
        {
            Order order = _mapper.Map<Order>(newOrder);
            await CreateAsync(order);
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await FirstOfDefaultAsync(x => x.Id == orderId);
        }
    }
}