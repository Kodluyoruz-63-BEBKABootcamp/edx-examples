using System;
namespace edx_project.Models.ViewModels
{
    public class AgeViewModel
    {
        public int Age { get; set; }

        public AgeViewModel()
        {
            Age = new Random().Next(0,90);
        }

        public override string ToString() //virtual
        {
            return Age.ToString();
        }
    }
}
