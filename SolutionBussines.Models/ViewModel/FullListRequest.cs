namespace SolutionBussines.Models.ViewModel
{
    public class FullListRequest
    {
        public string Draw { get; set; }
        public string Start { get; set; }
        public string Length { get; set; }
        public string SortColumn { get; set; }
        public string SortColumnDirection { get; set; }
        public string SearchValue { get; set; }
        public int PageSize { get => !string.IsNullOrEmpty(Length) ? Convert.ToInt32(Length) : 0; }
        public int Skip { get => !string.IsNullOrEmpty(Start) ? Convert.ToInt32(Start) : 0; }
        public int RecordsTotal { get; set; } = 0;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}