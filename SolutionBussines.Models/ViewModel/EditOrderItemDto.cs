using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SolutionBussines.Models.ViewModel
{
    public class EditOrderItemDto
    {
        public int Id { get; set; }

        [Required]
        [Remote("CheckName", "Validate", AdditionalFields = "OrderId")]
        public string Name { get; set; }

        [Precision(18, 3)]
        public decimal Quantity { get; set; }

        public string Unit { get; set; }
        public int OrderId { get; set; }
    }
}