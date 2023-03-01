namespace WebAPI_CRUD_CORE.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly DOB { get; set; }

    }
}
