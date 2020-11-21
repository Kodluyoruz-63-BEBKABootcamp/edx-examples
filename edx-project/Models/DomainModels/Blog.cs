using System;

namespace edx_project.Models.DomainModels
{
    public class Blog
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}