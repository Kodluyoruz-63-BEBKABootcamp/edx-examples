using System.Collections.Generic;
using edx_project.Models.DomainModels;

namespace edx_project.Models.ViewModels
{
    public class DirectorFilmsViewModel
    {
        public Director Director { get; set; }
        public IList<Film> Films { get; set; }
    }
}
