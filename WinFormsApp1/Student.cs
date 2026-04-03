namespace CodeFirst
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public double? PointAverage { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public virtual AcademyGroup AcademyGroup { get; set; }
    }
}
