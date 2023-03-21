using AutoMapper;
using SolutionBussines.DBRepository.Impl.ItemsRepository;
using SolutionBussines.DBRepository.Interfaces;

namespace SolutionBussines.DBRepository.Impl
{
    public class DbRepository : IDbRepository
    {
        private readonly SBDbContext _context;
        private readonly IMapper _mapper;

        public DbRepository(SBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IOrderRepository Order => new OrderRepository(_context, _mapper);
        public IOrderItemRepository OrderItem => new OrderItemRepository(_context, _mapper);
        public IProviderRepository Provider => new ProviderRepository(_context, _mapper);
    }
}