using System;
namespace edx_project.Models.DomainModels
{
    public partial class Actor
    {
        public int Actor_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Last_Update { get; set; }
    }
}
