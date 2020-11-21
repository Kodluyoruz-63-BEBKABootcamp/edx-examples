using System.Collections.Generic;
using edx_project.Models.DomainModels;

namespace edx_project.Models.ViewModels
{
    public class BlogViewModel
    {
        public BlogViewModel()
        {
            Blogs = new List<Blog>();
        }

        public Blog Featured { get; set; }
        public Blog[] SubFeatured { get; set; }
        public string About { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}