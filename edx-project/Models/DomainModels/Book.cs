using System;
using System.ComponentModel.DataAnnotations;

namespace edx_project.Models.DomainModels
{
    public class Book
    {
        [Required, Key]
        public int ISBN { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required, MaxLength(1000)]
        public string Description { get; set; }

        [Required, Range(0, 999.99)]
        public decimal Price { get; set; }

        [Url]
        public string SamplePage { get; set; }

        [EmailAddress]
        public string AuthorEmail { get; set; }

        [Phone]
        public string AuthorPhone { get; set; }
    }
}
