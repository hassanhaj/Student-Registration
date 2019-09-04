using StudentRegistration.Web.Entities;
using System.Collections.Generic;

namespace StudentRegistration.Web.Models
{
    public class StudentsHomeModel
    {
        public IEnumerable<Student> Students { get; set; }
        public List<Country> Countries { get; set; } = new List<Country>();
        public int PageNo { get; set; } = 1;
        public string Name { get; set; }
        public Student Student { get; set; }
    }
}
