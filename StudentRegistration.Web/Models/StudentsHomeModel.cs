using StudentRegistration.Web.Entities;
using System.Collections.Generic;

namespace StudentRegistration.Web.Models
{
    public class StudentsHomeModel
    {
        public IEnumerable<Student> Students { get; set; }
        public int PageNo { get; set; } = 1;
    }
}
