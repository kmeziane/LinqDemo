namespace LinqDemo
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LevelId { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}
