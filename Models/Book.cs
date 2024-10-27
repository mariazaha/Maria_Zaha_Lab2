using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Maria_Zaha_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Book Title is required.")]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid price.")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }

        
        public Publisher? Publisher { get; set; }
    }
}
