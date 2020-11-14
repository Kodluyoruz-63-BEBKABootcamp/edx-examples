namespace edx_project.Models.DTO
{
    public class CreateOrUpdateDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public bool IsInStore { get; set; }
        public Operation Operation { get; set; }
    }

    public enum Genre
    {
        Action,
        Comedy,
        War,
        // ...
    }

    public enum Operation
    {
        Create,
        Update,
        // ...
    }
}
