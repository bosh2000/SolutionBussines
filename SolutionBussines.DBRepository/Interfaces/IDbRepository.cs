namespace SolutionBussines.DBRepository.Interfaces
{
    public interface IDbRepository
    {
        IOrderRepository Order { get; }
        IOrderItemRepository OrderItem { get; }
        IProviderRepository Provider { get; }
    }
}