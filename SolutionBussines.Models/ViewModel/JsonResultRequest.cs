namespace SolutionBussines.Models.ViewModel
{
    [Serializable]
    public class JsonResultRequest
    {
        public string draw { get; set; }
        public int recordsFiltered { get; set; }
        public int recordsTotal { get; set; }
        public List<object>? data { get; set; }
    }
}