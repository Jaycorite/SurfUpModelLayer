using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfsUpBlazor.Shared.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Title is too long.")]
        public string Title { get; set; } = "Title";

        [Required]
        [StringLength(100, ErrorMessage = "Text is too long.")]
        public string Text { get; set; } = "Text";

        public DateTime PostedDate { get; set; } = DateTime.Now.Date;

        public override string ToString()
        {
            return $"{Title}, {Text}, PostedDate {PostedDate:dd/MM/yyyy}";
        }
    }
}
