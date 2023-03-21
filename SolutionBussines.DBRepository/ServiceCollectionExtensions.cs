using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SolutionBussines.DBRepository.Impl;
using SolutionBussines.DBRepository.Interfaces;

namespace SolutionBussines.DBRepository
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDbRepository(this IServiceCollection services, SBDbContext context, IMapper mapper)
        {
            if (context is null || mapper is null)
            {
                throw new ArgumentNullException();
            }
            services.AddScoped<IDbRepository, DbRepository>(x => new DbRepository(context, mapper));
        }
    }
}