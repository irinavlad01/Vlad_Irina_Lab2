using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Vlad_Irina_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string?  Title { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; } //navigation property
        public string? Price { get; set; }

        [Display(Name = "Publishing date")]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
    }
}
