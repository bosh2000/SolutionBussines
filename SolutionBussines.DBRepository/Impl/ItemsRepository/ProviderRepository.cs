using AutoMapper;
using SolutionBussines.DBRepository.Interfaces;
using SolutionBussines.Models.Db;

namespace SolutionBussines.DBRepository.Impl.ItemsRepository
{
    public class ProviderRepository : RepositoryBase<Provider>, IProviderRepository
    {
        public ProviderRepository(SBDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}