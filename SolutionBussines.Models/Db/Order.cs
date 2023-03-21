namespace SolutionBussines.Models.Db
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }
    }
}