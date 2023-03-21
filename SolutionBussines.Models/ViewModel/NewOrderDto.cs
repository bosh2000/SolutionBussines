using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SolutionBussines.Models.ViewModel
{
    public class NewOrderDto
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }

        [Required]
        [Remote("CheckNumber", "Validate", AdditionalFields = "Number")]
        public int SelectedProvider { get; set; }
    }
}