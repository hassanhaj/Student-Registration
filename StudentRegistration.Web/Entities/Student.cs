using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRegistration.Web.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string NationalId { get; set; }
        [Required]
        [StringLength(1000)]
        [Column(TypeName = "varchar(1000)")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public DateTime? GraduationDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int CountryId { get; set; }
    }
}
