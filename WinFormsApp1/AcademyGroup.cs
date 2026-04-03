using System.Collections.Generic;

namespace CodeFirst
{
    public class AcademyGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public int NumberOfStudents {  get; set; }   
        public virtual ICollection<Student> Students { get; set; }
    }
}
