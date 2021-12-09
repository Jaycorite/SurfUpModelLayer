using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfsUpBlazor.Shared.Models
{
    public class RentalPost
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Title is too long.")]
        public string Title { get; set; } = "Title";

        [Required]
        [RegularExpression(@".*\S+.*$", ErrorMessage = "Field Cannot be Blank Or Whitespace")]
        public string Category { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Price must be a positive number")]
        public int Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Price must be a positive number")]
        public int Deposit { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Description is too long.")]
        public string Description { get; set; } = "Description";

        [Required]
        public DateTime AvailableDateFrom { get; set; } = DateTime.Now.Date;

        [Required]
        public DateTime AvailableDateTo { get; set; } = DateTime.Now.Date.AddDays(1);     
        
        public DateTime PostedDate { get; set; } = DateTime.Now.Date;

        public override string ToString()
        {
            return $"{Title}, {Price}DKK, PostDate {PostedDate:dd/MM/yyyy}";
        }
    }
}
