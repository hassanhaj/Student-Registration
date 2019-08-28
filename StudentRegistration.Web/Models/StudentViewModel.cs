using StudentRegistration.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Web.Models
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Country> Countries { get; set; }

    }
}
