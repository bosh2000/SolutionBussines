using AutoMapper;
using SolutionBussines.Models.Db;
using SolutionBussines.Models.ViewModel;

namespace SolutionBussines.DBRepository
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<NewOrderDto, Order>()
                .ForMember(dest => dest.ProviderId, opt => opt.MapFrom(src => src.SelectedProvider));
            CreateMap<NewOrderItemDto, OrderItem>();
            CreateMap<OrderItem, EditOrderItemDto>();
            CreateMap<EditOrderItemDto, OrderItem>();
        }
    }
}